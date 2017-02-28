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
    public partial class frmCaezar : Form
    {
        public frmCaezar()
        {
            InitializeComponent();
        }

        NumericalAlphabet numAlphabet = new NumericalAlphabet();

        public Boolean checkEmptyFields()
        {
            // Check if there is a message to encrypt
            if (txtMessage.Text.Length > 0 || txtResult.Text.Length > 0)
            {
                // Check if there is a key specified
                if (txtKey.Text.Length > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Atslēga nedrīkst būt tukša!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Lūdzu ievadiet ziņu!");
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
                    MessageBox.Show("Neatpazīta funkcija!");
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

        public void prepareToCipher(string txtBoxText, string function)
        {
            // Prepare for cipher text display
            txtResult.Text = "";
            if (checkEmptyFields())
            {
                // Get plaintext and key
                char[] plaintextArray = txtBoxText.ToUpper().ToCharArray();
                int key = 0;
                try
                {
                    key = int.Parse(txtKey.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lūdzu norādīet atslēgu kā naturālu skaitli!");
                    txtKey.Text = "";
                }

                // Translate message to numerical values
                int[] message = numAlphabet.lettersToNumbers(plaintextArray);
                if (txtKey.Text != "")
                {
                    if (message != null)
                    {
                        txtResult.Text = cipher(message, key, function);
                    }
                    else
                    {
                        MessageBox.Show("Lūdzu izmantojiet tekstā tikai latīņu burtus no A līdz Z!");
                    }
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            prepareToCipher(txtMessage.Text, "E");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            prepareToCipher(txtMessage.Text, "D");
        }

        private void btnSaveToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }
    }
}
