using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using System.IO;

namespace Cryptographer
{
    public partial class frmRSASignature : frmRSASignatureBase
    {
        public frmRSASignature()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
            this.ActiveControl = txtSignedData;
        }

        frmRSASignatureInfo RSASignatureInfo;
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

        private void btnRSASignatureInfo_Click(object sender, EventArgs e)
        {
            if (!RSASignatureInfo.Visible)
            {
                RSASignatureInfo = new frmRSASignatureInfo();
                RSASignatureInfo.Show();
                if (txtSignedData.Text != "" && txtKey.Text != "")
                {
                    RSASignatureInfo.setMessageAndKey(txtSignedData.Text, txtKey.Text, txtSignature.Text);
                }
                this.Close();
            }
        }

        private void frmRSASignature_Load(object sender, EventArgs e)
        {
            rdoBtnEncrypt.Checked = true;
            RSASignatureInfo = new frmRSASignatureInfo();
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
            if (rdoBtnEncrypt.Checked)
            {
                lblSignedData.Text = "Signable data";
            }
            else if (rdoBtnDecrypt.Checked)
            {
                lblSignedData.Text = "Signed data";
            }
            else
            {
                MessageBox.Show("Select if you want to encrypt or decrypt the text");
            }
        }

        private void frmRSASignature_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmRSASignature RSASignatureCipher = new frmRSASignature();
            RSASignatureCipher.Close();
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
            } catch (ArgumentNullException)
            {
                return;
            }
        }
    }
}
