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
    public partial class frmVigenereBase : Form
    {
        public frmVigenereBase()
        {
            InitializeComponent();
        }

        NumericalAlphabet numAlphabet = new NumericalAlphabet();
        TextParser textParser = new TextParser();

        public Boolean checkEmptyFields(string message, string key)
        {
            // Check if there is a message to encrypt
            if (message.Length > 0)
            {
                // Check if there is a key specified
                if (key.Length > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("The key must not be empty!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a message!");
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
            try
            {
                if (message != null && key != null)
                {
                    // Create variables used withing the method
                    int[] resultMessageInInt = new int[message.Length];
                    int a;
                    int b;
                    int c = numAlphabet.getAlphabetLength();
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
                else
                {
                    MessageBox.Show("Please use only english letters from A to Z!");
                    throw new Exception();
                }
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public int[] prepareTextToCipher(string txtBoxText)
        {
            // Translate message and key to numerical values
            char[] plaintextArray = textParser.parseReplaceableLetters(txtBoxText.ToUpper().ToCharArray());
            int[] message = numAlphabet.lettersToNumbers(plaintextArray);

            return message;
        }

        public int[] prepareKeytoCipher(string txtBoxKey, int messageLength)
        {
            // Pad and translate key to numerical values
            char[] keyArray = textParser.parseReplaceableLetters(txtBoxKey.ToUpper().ToCharArray());
            char[] paddedKeyArray = createPaddedKey(keyArray, messageLength);
            int[] numericKey = numAlphabet.lettersToNumbers(paddedKeyArray);

            return numericKey;
        }

        protected void txtMessage_TextChanged(object sender, EventArgs e)
        {
            txtMessage.CharacterCasing = CharacterCasing.Upper;
            txtKey.CharacterCasing = CharacterCasing.Upper;
        }

        public void setMessageAndKey(string message, string key)
        {
            txtMessage.Text = message;
            txtKey.Text = key;
        }
    }
}
