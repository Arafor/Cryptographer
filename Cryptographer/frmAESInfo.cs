using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Cryptographer
{
    public partial class frmAESInfo : frmAESBase
    {
        public frmAESInfo()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
            this.ActiveControl = txtMessage;
        }

        frmAES AES;
        Aes myAES = new AesCryptoServiceProvider();

        private void btnAES_Click(object sender, EventArgs e)
        {
            if (!AES.Visible)
            {
                AES = new frmAES();
                AES.Show();
                if (txtMessage.Text != "" && txtKey.Text != "")
                {
                    AES.setMessageAndKey(txtMessage.Text, txtKey.Text, txtIV.Text);
                }
                this.Close();
            }
        }

        private void frmAESInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAESInfo AESInfo = new frmAESInfo();
            AESInfo.Close();
        }

        private void frmAESInfo_Load(object sender, EventArgs e)
        {
            rdoBtnEncrypt.Checked = true;
            AES = new frmAES();
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

        private void btnCipher_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields(txtMessage.Text))
            {
                // Prepare for cipher text display
                txtResult.Text = "";
                string message = txtMessage.Text;
                if (message != null)
                {
                    myAES.Mode = setSelectedMode();
                    try
                    {
                        if (rdoBinary.Checked)
                        {
                            if (txtKey.Text != "")
                            {
                                myAES.Key = parseBinaryStringToBytes(txtKey.Text);
                            }
                            if (txtIV.Text != "")
                            {
                                myAES.IV = parseBinaryStringToBytes(txtIV.Text);
                            }
                            else
                            {
                                myAES.GenerateIV();
                            }
                        }
                        else if (rdoHexadecimal.Checked)
                        {
                            if (txtKey.Text != "")
                            {
                                myAES.Key = parseHexadecimalStringToBytes(txtKey.Text);
                            }
                            if (txtIV.Text != "")
                            {
                                myAES.IV = parseHexadecimalStringToBytes(txtIV.Text);
                            }
                            else
                            {
                                myAES.GenerateIV();
                            }
                        }
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Check if the entered Key is correct", "Argument Exception");

                        return;
                    }
                    catch (System.Security.Cryptography.CryptographicException)
                    {
                        MessageBox.Show("Check if the entered IV is correct", "Cryptographic Exception");

                        return;
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Check if the entered IV is correct", "Format Exception");

                        return;
                    }
                    if (rdoBtnEncrypt.Checked)
                    {
                        //Plaintext to Ciphertext
                        byte[] encrypted = EncryptStringToBytes(message, myAES.Key, myAES.IV, myAES.Mode);
                        if (rdoBinary.Checked)
                        {
                            foreach (byte encryptedByte in encrypted)
                            {
                                txtResult.Text = txtResult.Text + Convert.ToString(encryptedByte, 2).PadLeft(8, '0');
                            }
                            //Print key
                            txtKey.Text = "";
                            foreach (byte keyByte in myAES.Key)
                            {
                                txtKey.Text = txtKey.Text + Convert.ToString(keyByte, 2).PadLeft(8, '0');
                            }
                            //Print IV
                            txtIV.Text = "";
                            foreach (byte IVByte in myAES.IV)
                            {
                                txtIV.Text = txtIV.Text + Convert.ToString(IVByte, 2).PadLeft(8, '0');
                            }
                        }
                        else if (rdoHexadecimal.Checked)
                        {
                            txtResult.Text = BitConverter.ToString(encrypted).Replace("-", "");
                            txtKey.Text = BitConverter.ToString(myAES.Key).Replace("-", "");
                            txtIV.Text = BitConverter.ToString(myAES.IV).Replace("-", "");
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
                                encrypted = parseBinaryStringToBytes(txtMessage.Text);
                            }
                            else if (rdoHexadecimal.Checked)
                            {
                                encrypted = parseHexadecimalStringToBytes(txtMessage.Text);
                            }
                            else
                            {
                                MessageBox.Show("Choose how you wish the values to be shown (Binary/Hexadecimal).");

                                return;
                            }
                            string roundtrip = DecryptStringFromBytes(encrypted, myAES.Key, myAES.IV, myAES.Mode);
                            txtResult.Text = roundtrip;

                            //Set Key text
                            txtKey.Text = "";
                            if (rdoBinary.Checked)
                            {
                                foreach (byte keyByte in myAES.Key)
                                {
                                    txtKey.Text = txtKey.Text + Convert.ToString(keyByte, 2).PadLeft(8, '0');
                                }
                            }
                            else if (rdoHexadecimal.Checked)
                            {
                                txtKey.Text = BitConverter.ToString(myAES.Key).Replace("-", "");
                            }
                            else
                            {
                                MessageBox.Show("Choose how you wish the values to be shown (Binary/Hexadecimal).");

                                return;
                            }
                        }
                        catch (System.Security.Cryptography.CryptographicException)
                        {
                            MessageBox.Show("Check if the entered ciphertext is correct", "Cryptographic error");

                            return;
                        }
                        catch (System.FormatException)
                        {
                            MessageBox.Show("Check the entered ciphertext", "Format exception");

                            return;
                        }
                        catch (System.ArgumentNullException)
                        {
                            MessageBox.Show("The ciphertext did not contain correct binary text");

                            return;
                        }
                        catch (System.ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("Given hexadecimal value is too short");

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
        }

        private void btnSaveToClipboard_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Clipboard.SetText(txtResult.Text);
            }
        }
    }
}
