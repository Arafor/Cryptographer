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
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
        }

        NumericalAlphabet numAlphabet = new NumericalAlphabet();

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
            } catch (Exception exc)
            {
                return null;
            }
        }

        public int[] prepareTextToCipher(string txtBoxText)
        {
            // Translate message and key to numerical values
            char[] plaintextArray = txtBoxText.ToUpper().ToCharArray();
            int[] message = numAlphabet.lettersToNumbers(plaintextArray);

            return message;
        }

        public int[] prepareKeytoCipher(string txtBoxKey, int messageLength)
        {
                // Pad and translate key to numerical values
                char[] keyArray = txtBoxKey.ToUpper().ToCharArray();
                char[] paddedKeyArray = createPaddedKey(keyArray, messageLength);
                int[] numericKey = numAlphabet.lettersToNumbers(paddedKeyArray);

                return numericKey;
        }

        private void btnSaveToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void btnVigenereInfo_Click(object sender, EventArgs e)
        {
            frmVigenereInfo vigenereInfo = new frmVigenereInfo();
            vigenereInfo.Show();
            if (txtMessage.Text != "" && txtKey.Text != "")
            {
                vigenereInfo.setMessageAndKey(txtMessage.Text, txtKey.Text);
            }
        }

        private void frmVigenere_Load(object sender, EventArgs e)
        {
            rdoBtnEncrypt.Checked = true;
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields(txtMessage.Text, txtKey.Text))
            {
                // Prepare to display result
                txtResult.Text = "";
                int[] message = prepareTextToCipher(txtMessage.Text);
                int[] key = prepareKeytoCipher(txtKey.Text, txtMessage.Text.Length);
                if (rdoBtnEncrypt.Checked)
                {
                    txtResult.Text = cipher(message, key, "E");
                }
                else if (rdoBtnDecrypt.Checked)
                {
                    txtResult.Text = cipher(message, key, "D");
                }
                else
                {
                    MessageBox.Show("Select if you want to encrypt or decrypt the text");
                }
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
    }
}
