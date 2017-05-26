using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Cryptographer
{
    public partial class frmRSASignatureInfo : frmRSASignatureBase
    {
        public frmRSASignatureInfo()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
            this.ActiveControl = txtSignedData;
        }

        frmRSASignature RSASignature;
        RSA myRSA = new RSACryptoServiceProvider();
        TextParser textParser = new TextParser();
        //Create a UnicodeEncoder to convert between byte array and string.
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        FileManager fileManager = new FileManager();

        private void btnSaveToClipboard_Click(object sender, EventArgs e)
        {
            if (txtSignature.Text != "")
            {
                Clipboard.SetText(txtSignature.Text);
            }
        }

        private void btnRSASignature_Click(object sender, EventArgs e)
        {
            if (!RSASignature.Visible)
            {
                RSASignature = new frmRSASignature();
                RSASignature.Show();
                if (txtSignedData.Text != "" && txtKey.Text != "")
                {
                    RSASignature.setMessageAndKey(txtSignedData.Text, txtKey.Text, txtSignature.Text);
                }
                this.Close();
            }
        }

        private void frmRSASignatureInfo_Load(object sender, EventArgs e)
        {
            RSASignature = new frmRSASignature();
            rdoBtnEncrypt.Checked = true;
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields(txtSignedData.Text))
            {
                byte[] message = ByteConverter.GetBytes(txtSignedData.Text);
                // Prepare for cipher text display
                if (rdoBtnEncrypt.Checked)
                {
                    txtSignature.Text = "";
                }
                if (txtKey.Text != "")
                {
                    try
                    {
                        myRSA.FromXmlString(txtKey.Text);
                    }
                    //catch (XmlSyntaxtExcpetion)
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                        return;
                    }
                }
                if (rdoBtnEncrypt.Checked)
                {

                    //Plaintext to Ciphertext
                    byte[] encrypted;
                    try
                    {
                        encrypted = HashAndSignBytes(message, myRSA.ExportParameters(true));
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);

                        return;
                    }

                    txtKey.Text = myRSA.ToXmlString(true);
                    if (rdoBinary.Checked)
                    {
                        txtSignature.Text = "";
                        foreach (byte encryptedByte in encrypted)
                        {
                            txtSignature.Text = txtSignature.Text + Convert.ToString(encryptedByte, 2).PadLeft(8, '0');
                        }
                    }
                    else if (rdoHexadecimal.Checked)
                    {
                        txtSignature.Text = BitConverter.ToString(encrypted).Replace("-", "");
                    }
                    else
                    {
                        MessageBox.Show("Choose how you wish the values to be shown (Binary/Hexadecimal).");

                        return;
                    }
                    printKeyParam();
                }
                else if (rdoBtnDecrypt.Checked)
                {
                    try
                    {
                        byte[] encrypted = null;
                        if (rdoBinary.Checked)
                        {
                            encrypted = textParser.parseBinaryStringToBytes(txtSignature.Text);
                        }
                        else if (rdoHexadecimal.Checked)
                        {
                            encrypted = textParser.parseHexadecimalStringToBytes(txtSignature.Text);
                        }
                        else
                        {
                            MessageBox.Show("Choose how you wish the values to be shown (Binary/Hexadecimal).");

                            return;
                        }
                        printKeyParam();
                        bool signatureCheck = VerifySignedHash(message, encrypted, myRSA.ExportParameters(false));
                        if (signatureCheck)
                        {
                            lblValidSignature.Text = "Signature matches the signed document.";
                            lblValidSignature.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblValidSignature.Text = "Signature does match the signed document.";
                            lblValidSignature.ForeColor = Color.Red;
                        }
                    }
                    catch (System.Security.Cryptography.CryptographicException)
                    {
                        MessageBox.Show("Check if the entered ciphertext is correct", "Cryptographic error");

                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Select if you want to encrypt or decrypt the text");

                    return;
                }
            }
            else
            {
                MessageBox.Show("Please use only letters from the english alphabet (A-Z)!");

                return;
            }
        }

        private void cipherRadioButtonChanged(object sender, EventArgs e)
        {
            lstFormula.Items.Clear();
            //Set formula description
            List<string> formula = new List<string>()
                {
                    "First we need to generate our keys.",
                    "Choose two big and secret prime numbers p and q.",
                    "Then we calculate n = p * q.",
                    "Then we choose our private key e where e is a coprime to the number ((p-1)*(q-1)).",
                    "Then we create our public key d=e^-1 mod((p-1)*(q-1)).",
                };
            if (rdoBtnEncrypt.Checked)
            {
                lblSignedData.Text = "Signable data";
                lblDescription5.Text = "To sign our document we use the following formula:";

                //Set encryption formula description
                formula.Add("After that we can begin to sign our document m.");
                formula.Add("c=m^d mod(n).");
            }
            else if (rdoBtnDecrypt.Checked)
            {
                lblSignedData.Text = "Signed data";
                lblDescription5.Text = "To validate our data we use the following formula:";

                //Set encryption formula description
                formula.Add("After that we can begin to validate our document c.");
                formula.Add("m=c^e mod(n).");
            }
            else
            {
                MessageBox.Show("Select if you want to encrypt or decrypt the text");
            }
            foreach (string line in formula)
            {
                lstFormula.Items.Add(line);
            }
        }

        private void frmRSASignatureInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmRSAInfo RSAInfo = new frmRSAInfo();
            RSAInfo.Close();
        }

        private void printKeyParam()
        {
            var myRSAKeyParam = myRSA.ExportParameters(true);

            //Print P
            string keyPText = "";
            foreach (byte keyByte in myRSAKeyParam.P)
            {
                keyPText = keyPText + keyByte;
            }
            txtP.Text = keyPText;

            //Print Q
            string keyQText = "";
            foreach (byte keyByte in myRSAKeyParam.Q)
            {
                keyQText = keyQText + keyByte;
            }
            txtQ.Text = keyQText;

            //Print N
            string keyNText = "";
            foreach (byte keyByte in myRSAKeyParam.Modulus)
            {
                keyNText = keyNText + keyByte;
            }
            txtN.Text = keyNText;

            //Print E
            string keyEText = "";
            foreach (byte keyByte in myRSAKeyParam.Exponent)
            {
                keyEText = keyEText + keyByte;
            }
            txtE.Text = keyEText;

            //Print D
            string keyDText = "";
            foreach (byte keyByte in myRSAKeyParam.D)
            {
                keyDText = keyDText + keyByte;
            }
            txtD.Text = keyDText;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] signableData = File.ReadAllBytes(fileManager.importFile());
                if (rdoBinary.Checked)
                {


                    string documentBinaryData = "";
                    foreach (byte documentByte in signableData)
                    {
                        if (documentBinaryData.Length < txtSignedData.MaxLength)
                        {
                            documentBinaryData = documentBinaryData + Convert.ToString(documentByte, 2).PadLeft(8, '0');
                        }
                        else
                        {
                            MessageBox.Show("The chosen file is too large.");

                            return;
                        }
                    }
                    txtSignedData.Text = documentBinaryData;

                }
                else if (rdoHexadecimal.Checked)
                {
                    if (signableData.Length < txtSignedData.MaxLength)
                    {
                        txtSignedData.Text = BitConverter.ToString(signableData).Replace("-", "");
                    }
                    else
                    {
                        MessageBox.Show("The chosen file is too large.");
                    }
                }
                else
                {
                    MessageBox.Show("Choose in what format to display values.");
                }
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }
    }
}
