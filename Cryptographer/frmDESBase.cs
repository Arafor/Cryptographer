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

        protected string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
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

        public string cipher(int[] messageInInt, int key, string function)
        {
            // Encrypt message using key
            for (int i = 0; i < messageInInt.Length; i++)
            {
                if (function == "E")
                {
                    messageInInt[i] = messageInInt[i] + key;
                }
                else if (function == "D")
                {
                    messageInInt[i] = messageInInt[i] - key;
                }
                else
                {
                    MessageBox.Show("Unknown function specified");
                    break;
                }
            }

            // Get the string value of our result message
            char[] messageInChar = numAlphabet.numbersToLetters(messageInInt);
            string messageInString = "";
            for (int i = 0; i < messageInChar.Length; i++)
            {
                messageInString = messageInString + messageInChar[i].ToString();
            }
            return messageInString;
        }

        public int[] getParsedMessage(string txtBoxText)
        {
            // Translate message to numerical values
            char[] plaintextArray = textParser.parseReplaceableLetters(txtBoxText.ToUpper().ToCharArray());
            int[] message = numAlphabet.lettersToNumbers(plaintextArray);

            return message;
        }

        protected void txtMessage_TextChanged(object sender, EventArgs e)
        {
            txtMessage.CharacterCasing = CharacterCasing.Upper;
        }

        public void setMessageAndKey(string message, string key)
        {
            txtMessage.Text = message;
            txtKey.Text = key;
        }

        public byte[] parseBinaryStringToBytes(string message)
        {
            int numOfBytes = message.Length / 8;
            byte[] bytes = new byte[numOfBytes];
            for (int i = 0; i < numOfBytes; ++i)
            {
                //try
                //{
                    bytes[i] = Convert.ToByte(message.Substring(8 * i, 8), 2);
                //} catch (FormatException)
                //{
                    //MessageBox.Show("Bad fromat");
                //}
            }

            return bytes;
        }

        private void grpMode_CheckedChanged(object sender, EventArgs e)
        {

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

        protected byte[] parseHexadecimalStringToBytes(string message)
        {
            int messageLength = message.Length;
            byte[] bytes = new byte[messageLength / 2];
            for (int i = 0; i < messageLength; i += 2) bytes[i / 2] = Convert.ToByte(message.Substring(i, 2), 16);
            return bytes;
        }
    }
}
