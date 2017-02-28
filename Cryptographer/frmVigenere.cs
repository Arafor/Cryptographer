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
    public partial class frmVigenere : Form
    {
        public frmVigenere()
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

        public char[] createPaddedKey(char[] key, int length)
        {
            // If the key length is shorter than the messages then repeat the key until the length equals the messages length
            int j = 0;
            char[] paddedKeyArray = new char[length];
            for (int i = 0; i < length; i++)
            {
                if (j >= key.Length)
                {
                    j = 0;
                }
                paddedKeyArray[i] = key[j];
                j++;
            }

            return paddedKeyArray;
        }

        public String cipher(int[] message, int[] key, string function)
        {
            // Create variables used withing the method
            int[] resultMessageInInt = new int[message.Length];
            int a;
            int b;
            int c = numAlphabet.alphabetLength();
            int result = 0;

            // Create the numeric array of the message to get
            for (int i = 0; i < key.Length; i++)
            {
                a = message[i];
                b = key[i];
                // Specifies encryption
                if (function == "E")
                {
                    result = ((a + b) % c);
                }
                // Specifies decryption
                else if (function == "D")
                {
                    result = ((c + (a - b)) % c);
                }
                resultMessageInInt[i] = result;
            }

            // Get the string value of our result message
            char[] resultMessageInChar = numAlphabet.numbersToLetters(resultMessageInInt);
            string resultMessageInString = "";
            for (int i = 0; i < resultMessageInChar.Length; i++)
            {
                resultMessageInString = resultMessageInString + resultMessageInChar[i].ToString();
            }

            return resultMessageInString;
        }

        private void prepareToCipher(string txtBoxText, string function)
        {
            // Prepare for cipher text display
            txtResult.Text = "";
            if (checkEmptyFields())
            {
                // Get plaintext and key with lengths
                char[] plaintextArray = txtBoxText.ToUpper().ToCharArray();
                char[] keyArray = txtKey.Text.ToUpper().ToCharArray();

                // Create a padded key (same length as the message)
                char[] paddedKeyArray = createPaddedKey(keyArray, plaintextArray.Length);

                // Translate message and key to numerical values
                int[] message = numAlphabet.lettersToNumbers(plaintextArray);
                int[] numericKey = numAlphabet.lettersToNumbers(paddedKeyArray);
                if (message != null && numericKey != null)
                {
                    txtResult.Text = cipher(message, numericKey, function);
                }
                else
                {
                    MessageBox.Show("Lūdzu izmantojiet tekstā tikai latīņu burtus no A līdz Z!");
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
