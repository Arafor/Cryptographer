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
            if (txtPlaintext.Text.Length > 0 || txtCiphertext.Text.Length > 0)
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

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Prepare for cipher text display
            txtCiphertext.Text = "";
            if (checkEmptyFields())
            {
                // Get plaintext and key
                char[] plaintextArray = txtPlaintext.Text.ToUpper().ToCharArray();
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
                        txtCiphertext.Text = cipher(message, key, "E");
                    }
                    else
                    {
                        MessageBox.Show("Lūdzu izmantojiet tekstā tikai latīņu burtus no A līdz Z!");
                    }
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Prepare for cipher text display
            txtPlaintext.Text = "";
            if (checkEmptyFields())
            {
                // Get plaintext and key
                char[] ciphertextArray = txtCiphertext.Text.ToUpper().ToCharArray();
                int key = int.Parse(txtKey.Text);

                // Translate message to numerical values
                int[] message = numAlphabet.lettersToNumbers(ciphertextArray);
                if (message != null && key != null)
                {
                    txtPlaintext.Text = cipher(message, key, "D");
                }
                else
                {
                    MessageBox.Show("Lūdzu izmantojiet tekstā tikai latīņu burtus no A līdz Z!");
                }
            }
        }
    }
}
