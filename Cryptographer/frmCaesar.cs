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
    public partial class frmCaesar : Form
    {
        public frmCaesar()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
        }

        NumericalAlphabet numAlphabet = new NumericalAlphabet();

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
            char[] plaintextArray = txtBoxText.ToUpper().ToCharArray();
            int[] message = numAlphabet.lettersToNumbers(plaintextArray);

            return message;
        }

        public int getParsedKey(string txtBoxKey)
        {
            int key = int.Parse(txtBoxKey);

            return key;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields(txtMessage.Text, txtKey.Text))
            {
                // Prepare for cipher text display
                txtResult.Text = "";
                int[] message = getParsedMessage(txtMessage.Text);
                int key = getParsedKey(txtKey.Text);
                if (message != null)
                {
                    txtResult.Text = cipher(message, key, "E");
                }
                else
                {
                    MessageBox.Show("Please use only letters from the english alphabet (A-Z)!");
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields(txtMessage.Text, txtKey.Text))
            {
                // Prepare for cipher text display
                txtResult.Text = "";
                int[] message = getParsedMessage(txtMessage.Text);
                int key = getParsedKey(txtKey.Text);
                if (message != null)
                {
                    txtResult.Text = cipher(message, key, "D");
                }
                else
                {
                    MessageBox.Show("Please use only letters from the english alphabet (A-Z)!");
                }
            }
        }

        private void btnSaveToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void btnCaesarInfo_Click(object sender, EventArgs e)
        {
            frmCaesarInfo caesarInfo = new frmCaesarInfo();
            caesarInfo.Show();
            if (txtMessage.Text != "" && txtKey.Text != "")
            {
                caesarInfo.setMessageAndKey(txtMessage.Text, txtKey.Text);
            }
        }
    }
}
