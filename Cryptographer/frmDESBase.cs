using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Cryptographer
{
    public partial class frmDESBase : Form
    {
        public frmDESBase()
        {
            InitializeComponent();
        }

        NumericalAlphabet numAlphabet = new NumericalAlphabet();
        TextParser textParser = new TextParser();

        protected byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV, CipherMode Mode)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;
            // Create an DESCryptoServiceProvider object
            // with the specified key and IV.
            using (DES tdsAlg = new DESCryptoServiceProvider())
            {
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;
                tdsAlg.Mode = Mode;

                // Create an encrytor to perform the stream transform.
                ICryptoTransform encryptor = tdsAlg.CreateEncryptor(tdsAlg.Key, tdsAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream.
            return encrypted;

        }

        protected string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV, CipherMode Mode)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an TripleDESCryptoServiceProvider object
            // with the specified key and IV.
            using (DES tdsAlg = new DESCryptoServiceProvider())
            {
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;
                tdsAlg.Mode = Mode;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = tdsAlg.CreateDecryptor(tdsAlg.Key, tdsAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;
        }

        public Boolean checkEmptyFields(string txtBoxMessage)
        {
            // Check if there is a message to encrypt
            if (txtBoxMessage.Length > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a message");

                return false;
            }
        }

        public void setMessageAndKey(string message, string key, string IV)
        {
            txtMessage.Text = message;
            txtKey.Text = key;
            txtIV.Text = IV;
        }

        //Display values in binary or hexadecimal
        private void grpValueDisplayMode_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoBinary.Checked)
                {
                    //Convert key
                    string keyText = txtKey.Text;
                    txtKey.Text = "";
                    foreach (byte keyByte in textParser.parseHexadecimalStringToBytes(keyText))
                    {
                        txtKey.Text = txtKey.Text + Convert.ToString(keyByte, 2).PadLeft(8, '0');
                    }

                    //Convert IV
                    string IVText = txtIV.Text;
                    txtIV.Text = "";
                    foreach (byte IVByte in textParser.parseHexadecimalStringToBytes(IVText))
                    {
                        txtIV.Text = txtIV.Text + Convert.ToString(IVByte, 2).PadLeft(8, '0');
                    }
                }
                else if (rdoHexadecimal.Checked)
                {
                    //Convert Key
                    txtKey.Text = BitConverter.ToString(textParser.parseBinaryStringToBytes(txtKey.Text)).Replace("-", "");
                    //Convert IV
                    txtIV.Text = BitConverter.ToString(textParser.parseBinaryStringToBytes(txtIV.Text)).Replace("-", "");
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Check the entered Key or IV", "Argument Exception");

                return;
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("Check the entered Key or IV", "Cryptographic Exception");

                return;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Check the entered Key or IV", "Format Exception");

                return;
            }
        }

        protected System.Security.Cryptography.CipherMode setSelectedMode()
        {
            if (rdoCBC.Checked)      return System.Security.Cryptography.CipherMode.CBC;
            else if (rdoCFB.Checked) return System.Security.Cryptography.CipherMode.CFB;
            //else if (rdoCTS.Checked) return System.Security.Cryptography.CipherMode.CTS;
            else if (rdoECB.Checked) return System.Security.Cryptography.CipherMode.ECB;
            //else if (rdoOFB.Checked) return System.Security.Cryptography.CipherMode.OFB;

            //Set default
            rdoCBC.Checked = true;

            return System.Security.Cryptography.CipherMode.CBC;
        }
    }
}
