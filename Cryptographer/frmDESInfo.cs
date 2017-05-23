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
    public partial class frmDESInfo : frmDESBase
    {
        public frmDESInfo()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
            this.ActiveControl = txtMessage;
        }

        frmDES DES;
        DES myDES = new DESCryptoServiceProvider();
        TextParser textParser = new TextParser();

        private void btnDES_Click(object sender, EventArgs e)
        {
            if (!DES.Visible)
            {
                DES = new frmDES();
                DES.Show();
                if (txtMessage.Text != "" && txtKey.Text != "")
                {
                    DES.setMessageAndKey(txtMessage.Text, txtKey.Text, txtIV.Text);
                }
                this.Close();
            }
        }

        private void frmDESInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDESInfo DESInfo = new frmDESInfo();
            DESInfo.Close();
        }

        private void frmDESInfo_Load(object sender, EventArgs e)
        {
            rdoBtnEncrypt.Checked = true;
            DES = new frmDES();
        }

        private void btnSaveToClipboard_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Clipboard.SetText(txtResult.Text);
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

        private void btnCipher_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields(txtMessage.Text))
            {
                // Prepare for cipher text display
                txtResult.Text = "";
                string message = txtMessage.Text;
                if (message != null)
                {
                    myDES.Mode = setSelectedMode();
                    try
                    {
                        if (rdoBinary.Checked)
                        {
                            if (txtKey.Text != "")
                            {
                                myDES.Key = textParser.parseBinaryStringToBytes(txtKey.Text);
                            }
                            if (txtIV.Text != "")
                            {
                                myDES.IV = textParser.parseBinaryStringToBytes(txtIV.Text);
                            }
                            else
                            {
                                myDES.GenerateIV();
                            }
                        }
                        else if (rdoHexadecimal.Checked)
                        {
                            if (txtKey.Text != "")
                            {
                                myDES.Key = textParser.parseHexadecimalStringToBytes(txtKey.Text);
                            }
                            if (txtIV.Text != "")
                            {
                                myDES.IV = textParser.parseHexadecimalStringToBytes(txtIV.Text);
                            }
                            else
                            {
                                myDES.GenerateIV();
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
                        byte[] encrypted = EncryptStringToBytes(message, myDES.Key, myDES.IV, myDES.Mode);
                        if (rdoBinary.Checked)
                        {
                            foreach (byte encryptedByte in encrypted)
                            {
                                txtResult.Text = txtResult.Text + Convert.ToString(encryptedByte, 2).PadLeft(8, '0');
                            }
                            //Print key
                            txtKey.Text = "";
                            foreach (byte keyByte in myDES.Key)
                            {
                                txtKey.Text = txtKey.Text + Convert.ToString(keyByte, 2).PadLeft(8, '0');
                            }
                            //Print IV
                            txtIV.Text = "";
                            foreach (byte IVByte in myDES.IV)
                            {
                                txtIV.Text = txtIV.Text + Convert.ToString(IVByte, 2).PadLeft(8, '0');
                            }
                        }
                        else if (rdoHexadecimal.Checked)
                        {
                            txtResult.Text = BitConverter.ToString(encrypted).Replace("-", "");
                            txtKey.Text = BitConverter.ToString(myDES.Key).Replace("-", "");
                            txtIV.Text = BitConverter.ToString(myDES.IV).Replace("-", "");
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
                            string roundtrip = DecryptStringFromBytes(encrypted, myDES.Key, myDES.IV, myDES.Mode);
                            txtResult.Text = roundtrip;

                            //Set Key text
                            txtKey.Text = "";
                            if (rdoBinary.Checked)
                            {
                                foreach (byte keyByte in myDES.Key)
                                {
                                    txtKey.Text = txtKey.Text + Convert.ToString(keyByte, 2).PadLeft(8, '0');
                                }
                            }
                            else if (rdoHexadecimal.Checked)
                            {
                                txtKey.Text = BitConverter.ToString(myDES.Key).Replace("-", "");
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
    }
}
