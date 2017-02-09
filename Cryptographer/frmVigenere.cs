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

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Prepare for cipher text display
            txtCiphertext.Text = "";
            if (checkEmptyFields())
            {
                // Get plaintext and key with lengths
                char[] plaintextArray = txtPlaintext.Text.ToUpper().ToCharArray();
                char[] keyArray = txtKey.Text.ToUpper().ToCharArray();

                // Create a padded key (same length as the message)
                char[] paddedKeyArray = createPaddedKey(keyArray, plaintextArray.Length);

                // Translate message and key to numerical values
                int[] message = numAlphabet.lettersToNumbers(plaintextArray);
                int[] numericKey = numAlphabet.lettersToNumbers(paddedKeyArray);
                if (message != null && numericKey != null)
                {
                    txtCiphertext.Text = cipher(message, numericKey, "E");
                }
                else
                {
                    MessageBox.Show("Lūdzu izmantojiet tekstā tikai latīņu burtus no A līdz Z!");
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Prepare for plaintext text display
            txtPlaintext.Text = "";
            if (checkEmptyFields())
            {
                // Get ciphertext and key with lengths
                char[] ciphertextArray = txtCiphertext.Text.ToUpper().ToCharArray();
                char[] keyArray = txtKey.Text.ToUpper().ToCharArray();

                // Create a padded key (same length as the message)
                char[] paddedKeyArray = createPaddedKey(keyArray, ciphertextArray.Length);

                // Translate message and key to numerical values
                int[] message = numAlphabet.lettersToNumbers(ciphertextArray);
                int[] numericKey = numAlphabet.lettersToNumbers(paddedKeyArray);
                if (message != null && numericKey != null)
                {
                    txtPlaintext.Text = cipher(message, numericKey, "D");
                }
                else
                {
                    MessageBox.Show("Lūdzu izmantojiet tekstā tikai latīņu burtus no A līdz Z!");
                }
            }
        }
    }
}
