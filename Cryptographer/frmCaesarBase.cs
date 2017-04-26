using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptographer
{
    public partial class frmCaesarBase : Form
    {
        public frmCaesarBase()
        {
            InitializeComponent();
        }

        NumericalAlphabet numAlphabet = new NumericalAlphabet();
        TextParser textParser = new TextParser();

        public Boolean checkEmptyFields(string txtBoxMessage, string txtBoxKey)
        {
            // Check if there is a message to encrypt
            if (txtBoxMessage.Length > 0)
            {
                // Check if there is a key specified
                if (txtBoxKey.Length > 0)
                {
                    try
                    {
                        // Check if key is of type integer
                        int.Parse(txtBoxKey);

                        return true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("The key must be an integer");

                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a key");
                    return false;
                }
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

        public int getParsedKey(string txtBoxKey)
        {
            int key = int.Parse(txtBoxKey);

            return key;
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
    }
}
