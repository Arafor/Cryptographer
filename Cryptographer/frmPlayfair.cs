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
    public partial class frmPlayfair : Form
    {
        char[] allowedLetters =
        {
                Convert.ToChar("A"),
                Convert.ToChar("B"),
                Convert.ToChar("C"),
                Convert.ToChar("D"),
                Convert.ToChar("E"),
                Convert.ToChar("F"),
                Convert.ToChar("G"),
                Convert.ToChar("H"),
                Convert.ToChar("I"),
                Convert.ToChar("J"),
                Convert.ToChar("K"),
                Convert.ToChar("L"),
                Convert.ToChar("M"),
                Convert.ToChar("N"),
                Convert.ToChar("O"),
                Convert.ToChar("P"),
                Convert.ToChar("Q"),
                Convert.ToChar("R"),
                Convert.ToChar("S"),
                Convert.ToChar("T"),
                Convert.ToChar("U"),
                Convert.ToChar("V"),
                Convert.ToChar("W"),
                Convert.ToChar("X"),
                Convert.ToChar("Y"),
                Convert.ToChar("Z")
        };

        char[] replaceableLetters =
        {
                Convert.ToChar(" "),
                Convert.ToChar(","),
                Convert.ToChar("."),
                Convert.ToChar("?"),
                Convert.ToChar("!"),
        };

        char[,] table = new char[5, 5];

        public char[] parseText(char[] message)
        {
            // List holds parsed message (valid letters, without unnecessary symbols)
            var parsedMessage = new List<char>();
            // Iterate through our current message
            for (int i = 0; i < message.Length; i++)
            {
                // If letter is replaceable by "" then skip to the next letter
                bool skip = false;
                for (int j = 0; j < replaceableLetters.Length; j++)
                {
                    if (message[i] == replaceableLetters[j])
                    {
                        skip = true;
                        break;
                    }
                }

                if (skip) continue;

                // If the letter in the message is valid then add it to the parsed message
                int k = -1;
                for (k = 0; k < allowedLetters.Length; k++)
                {
                    if (message[i] == allowedLetters[k])
                    {
                        parsedMessage[i] = message[i];
                        break;
                    }
                }
                if (k >= allowedLetters.Length)
                {
                    MessageBox.Show("Please use only latin letters form A to Z in your message!");
                    return null;
                }
            }

            // Insert Q between repeating words
            message = parsedMessage.ToArray();
            //parsedMessage = new List<char>();
            string messageWithQ = "";
            string tmpWord = "";
            string word = "";
            foreach (char letter in message)
            {
                // Check if the word we have so far is contained in our temporary string
                if (tmpWord.Contains(word + letter))
                {
                    word = word + letter;
                }
                // if our word is no longer contained in our temporary string, check if the temporary string ends with it
                else if (tmpWord.EndsWith(word))
                {
                    // Move our temporary string to the message with a Q since the last two words are the same
                    messageWithQ = messageWithQ + tmpWord + "Q" + word;
                    // Move the last word to the temporary string for furthur comparisons
                    tmpWord = letter.ToString();
                    // Start a new word for compairing
                    word = "";

                }
                // If the temporary string contained the word but didnt end with it, then we apend it without any Q
                else
                {
                    tmpWord = tmpWord + word + letter;
                    word = "";
                    if (messageWithQ.EndsWith(tmpWord))
                    {
                        // Move our temporary string to the message with a Q since the last two words are the same
                        messageWithQ = messageWithQ + "Q" + tmpWord;
                        // Move the last word to the temporary string for furthur comparisons
                        tmpWord = "";
                    }
                }
            }

            return parsedMessage.ToArray();
        }

        public frmPlayfair()
        {
            InitializeComponent();
        }

        public void fillUITable()
        {
            txtTable00.Text = table[0, 0].ToString();
            txtTable01.Text = table[0, 1].ToString();
            txtTable02.Text = table[0, 2].ToString();
            txtTable03.Text = table[0, 3].ToString();
            txtTable04.Text = table[0, 4].ToString();
            txtTable10.Text = table[1, 0].ToString();
            txtTable11.Text = table[1, 1].ToString();
            txtTable12.Text = table[1, 2].ToString();
            txtTable13.Text = table[1, 3].ToString();
            txtTable14.Text = table[1, 4].ToString();
            txtTable20.Text = table[2, 0].ToString();
            txtTable21.Text = table[2, 1].ToString();
            txtTable22.Text = table[2, 2].ToString();
            txtTable23.Text = table[2, 3].ToString();
            txtTable24.Text = table[2, 4].ToString();
            txtTable30.Text = table[3, 0].ToString();
            txtTable31.Text = table[3, 1].ToString();
            txtTable32.Text = table[3, 2].ToString();
            txtTable33.Text = table[3, 3].ToString();
            txtTable34.Text = table[3, 4].ToString();
            txtTable40.Text = table[4, 0].ToString();
            txtTable41.Text = table[4, 1].ToString();
            txtTable42.Text = table[4, 2].ToString();
            txtTable43.Text = table[4, 3].ToString();
            txtTable44.Text = table[4, 4].ToString();

        }

        public void fillArrayTable()
        {
            table[0, 0] = txtTable00.Text[0];
            table[0, 1] = txtTable01.Text[0];
            table[0, 2] = txtTable02.Text[0];
            table[0, 3] = txtTable03.Text[0];
            table[0, 4] = txtTable04.Text[0];
            table[1, 0] = txtTable10.Text[0];
            table[1, 1] = txtTable11.Text[0];
            table[1, 2] = txtTable12.Text[0];
            table[1, 3] = txtTable13.Text[0];
            table[1, 4] = txtTable14.Text[0];
            table[2, 0] = txtTable20.Text[0];
            table[2, 1] = txtTable21.Text[0];
            table[2, 2] = txtTable22.Text[0];
            table[2, 3] = txtTable23.Text[0];
            table[2, 4] = txtTable24.Text[0];
            table[3, 0] = txtTable30.Text[0];
            table[3, 1] = txtTable31.Text[0];
            table[3, 2] = txtTable32.Text[0];
            table[3, 3] = txtTable33.Text[0];
            table[3, 4] = txtTable34.Text[0];
            table[4, 0] = txtTable40.Text[0];
            table[4, 1] = txtTable41.Text[0];
            table[4, 2] = txtTable42.Text[0];
            table[4, 3] = txtTable43.Text[0];
            table[4, 4] = txtTable44.Text[0];
        }

        private void tblTable_TextChanged(object sender, EventArgs e)
        {
            txtTable00.Text = txtTable00.Text.ToUpper();
            txtTable01.Text = txtTable01.Text.ToUpper();
            txtTable02.Text = txtTable02.Text.ToUpper();
            txtTable03.Text = txtTable03.Text.ToUpper();
            txtTable04.Text = txtTable04.Text.ToUpper();
            txtTable10.Text = txtTable10.Text.ToUpper();
            txtTable11.Text = txtTable11.Text.ToUpper();
            txtTable12.Text = txtTable12.Text.ToUpper();
            txtTable13.Text = txtTable13.Text.ToUpper();
            txtTable14.Text = txtTable14.Text.ToUpper();
            txtTable20.Text = txtTable20.Text.ToUpper();
            txtTable21.Text = txtTable21.Text.ToUpper();
            txtTable22.Text = txtTable22.Text.ToUpper();
            txtTable23.Text = txtTable23.Text.ToUpper();
            txtTable24.Text = txtTable24.Text.ToUpper();
            txtTable30.Text = txtTable30.Text.ToUpper();
            txtTable31.Text = txtTable31.Text.ToUpper();
            txtTable32.Text = txtTable32.Text.ToUpper();
            txtTable33.Text = txtTable33.Text.ToUpper();
            txtTable34.Text = txtTable34.Text.ToUpper();
            txtTable40.Text = txtTable40.Text.ToUpper();
            txtTable41.Text = txtTable41.Text.ToUpper();
            txtTable42.Text = txtTable42.Text.ToUpper();
            txtTable43.Text = txtTable43.Text.ToUpper();
            txtTable44.Text = txtTable44.Text.ToUpper();
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            fillArrayTable();
            char[] message = txtMessage.Text.ToCharArray();
            parseText(message);
            
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtTable00.Text = "";
            txtTable01.Text = "";
            txtTable02.Text = "";
            txtTable03.Text = "";
            txtTable04.Text = "";
            txtTable10.Text = "";
            txtTable11.Text = "";
            txtTable12.Text = "";
            txtTable13.Text = "";
            txtTable14.Text = "";
            txtTable20.Text = "";
            txtTable21.Text = "";
            txtTable22.Text = "";
            txtTable23.Text = "";
            txtTable24.Text = "";
            txtTable30.Text = "";
            txtTable31.Text = "";
            txtTable32.Text = "";
            txtTable33.Text = "";
            txtTable34.Text = "";
            txtTable40.Text = "";
            txtTable41.Text = "";
            txtTable42.Text = "";
            txtTable43.Text = "";
            txtTable44.Text = "";
        }

        private void btnAutoFill_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    // Index of letter to add
                    int resultLetter = -1;
                    // J is not contained in the table and must be avoided
                    if (i + j >= 9)
                    {
                        resultLetter = i + j + 1;
                    } else
                    {
                        resultLetter = i + j;
                    }
                    // Auto fill the table with latters from A to Z (without J)
                    table[i, j] = allowedLetters[resultLetter];
                }
            }
            fillUITable();
        }

        private void btnSaveToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text.ToUpper();
        }
    }
}
