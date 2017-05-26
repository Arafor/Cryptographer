using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace Cryptographer
{
    public partial class frmRSAInfo : frmRSABase
    {
        public frmRSAInfo()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
            this.ActiveControl = txtMessage;
        }

        frmRSA RSA;
        RSA myRSA = new RSACryptoServiceProvider();
        TextParser textParser = new TextParser();
        //Create a UnicodeEncoder to convert between byte array and string.
        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        private void btnSaveToClipboard_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Clipboard.SetText(txtResult.Text);
            }
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            if (!RSA.Visible)
            {
                RSA = new frmRSA();
                RSA.Show();
                if (txtMessage.Text != "" && txtKey.Text != "")
                {
                    RSA.setMessageAndKey(txtMessage.Text, txtKey.Text);
                }
                this.Close();
            }
        }

        private void frmRSAInfo_Load(object sender, EventArgs e)
        {
            RSA = new frmRSA();
            rdoBtnEncrypt.Checked = true;
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields(txtMessage.Text))
            {
                // Prepare for cipher text display
                txtResult.Text = "";
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
                    byte[] message = ByteConverter.GetBytes(txtMessage.Text);

                    //Plaintext to Ciphertext
                    byte[] encrypted;
                    try
                    {
                        encrypted = RSAEncrypt(message, myRSA.ExportParameters(false), false);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);

                        return;
                    }
                    txtKey.Text = myRSA.ToXmlString(true);
                    if (rdoBinary.Checked)
                    {
                        txtResult.Text = "";
                        foreach (byte encryptedByte in encrypted)
                        {
                            txtResult.Text = txtResult.Text + Convert.ToString(encryptedByte, 2).PadLeft(8, '0');
                        }
                    }
                    else if (rdoHexadecimal.Checked)
                    {
                        txtResult.Text = BitConverter.ToString(encrypted).Replace("-", "");
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
                            encrypted = textParser.parseBinaryStringToBytes(txtMessage.Text);
                        }
                        else if (rdoHexadecimal.Checked)
                        {
                            encrypted = textParser.parseHexadecimalStringToBytes(txtMessage.Text);
                        }
                        else
                        {
                            MessageBox.Show("Choose how you wish the values to be shown (Binary/Hexadecimal).");

                            return;
                        }
                        byte[] decryptedByteArray = RSADecrypt(encrypted, myRSA.ExportParameters(true), false);
                        try
                        {
                            //Print result
                            foreach (byte decryptedByte in decryptedByteArray)
                            {
                                txtResult.Text = txtResult.Text + Convert.ToChar(decryptedByte).ToString();
                            }
                        }
                        catch (NullReferenceException exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                        printKeyParam();
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
                lblMessage.Text = "Plaintext";
                lblResult.Text = "Ciphertext";
                lblDescription5.Text = "To encrypt our data we use the following formulas:";

                //Set encryption formula description
                formula.Add("After that we can begin to encrypt our data m.");
                formula.Add("c=m^e mod(n).");
            }
            else if (rdoBtnDecrypt.Checked)
            {
                lblMessage.Text = "Ciphertext";
                lblResult.Text = "Plaintext";
                lblDescription5.Text = "To decrypt our data we use the following formulas:";

                //Set encryption formula description
                formula.Add("After that we can begin to decrypt our data c.");
                formula.Add("m=c^d mod(n).");
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

        private void frmRSAInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmRSAInfo RSAInfo= new frmRSAInfo();
            RSAInfo.Close();
        }

        private void printKeyParam()
        {
            var myRSAKeyParam = myRSA.ExportParameters(true);

            //Print P
            string keyPText = "";
            foreach (byte keyByte in myRSAKeyParam.P)
            {
                keyPText = keyPText + Convert.ToString(keyByte, 2).PadLeft(8, '0');
            }
            txtP.Text = keyPText;

            //Print Q
            string keyQText = "";
            foreach (byte keyByte in myRSAKeyParam.Q)
            {
                keyQText = keyQText + Convert.ToString(keyByte, 2).PadLeft(8, '0');
            }
            txtQ.Text = keyQText;

            //Print N
            string keyNText = "";
            foreach (byte keyByte in myRSAKeyParam.Modulus)
            {
                keyNText = keyNText + Convert.ToString(keyByte, 2).PadLeft(8, '0');
            }
            txtN.Text = keyNText;

            //Print E
            string keyEText = "";
            foreach (byte keyByte in myRSAKeyParam.Exponent)
            {
                keyEText = keyEText + Convert.ToString(keyByte, 2).PadLeft(8, '0');
            }
            txtE.Text = keyEText;

            //Print D
            string keyDText = "";
            foreach (byte keyByte in myRSAKeyParam.D)
            {
                keyDText = keyDText + Convert.ToString(keyByte, 2).PadLeft(8, '0');
            }
            txtD.Text = keyDText;
        }
    }
}
