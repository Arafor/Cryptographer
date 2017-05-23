using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Cryptographer
{
    public partial class frmRSA : frmRSABase
    {
        public frmRSA()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
            this.ActiveControl = txtMessage;
        }

        frmRSAInfo RSAInfo;
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

        private void btnRSAInfo_Click(object sender, EventArgs e)
        {
            if (!RSAInfo.Visible)
            {
                RSAInfo = new frmRSAInfo();
                RSAInfo.Show();
                if (txtMessage.Text != "" && txtKey.Text != "")
                {
                    RSAInfo.setMessageAndKey(txtMessage.Text, txtKey.Text);
                }
                this.Close();
            }
        }

        private void frmRSA_Load(object sender, EventArgs e)
        {
            rdoBtnEncrypt.Checked = true;
            RSAInfo = new frmRSAInfo();
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
                    } catch (Exception exc)
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
                            foreach (byte decryptedByte in decryptedByteArray)
                            {
                                txtResult.Text = txtResult.Text + Convert.ToChar(decryptedByte).ToString();
                            }
                        }
                        catch (NullReferenceException exc)
                        {
                            MessageBox.Show(exc.ToString());
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
                lblMessage.Text = "Plaintext";
                lblResult.Text = "Ciphertext";
            }
            else if (rdoBtnDecrypt.Checked)
            {
                lblMessage.Text = "Ciphertext";
                lblResult.Text = "Plaintext";
            }
            else
            {
                MessageBox.Show("Select if you want to encrypt or decrypt the text");
            }
        }

        private void frmRSA_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmRSA RSACipher = new frmRSA();
            RSACipher.Close();
        }
    }
}
