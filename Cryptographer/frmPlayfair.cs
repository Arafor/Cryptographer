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
                        // Replace letter "J" with "I"
                        if (j == 9)
                        {
                            parsedMessage.Insert(j, replaceableLetters[j - 1]);
                        }
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
                        parsedMessage.Insert(i, message[i]);
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
            string messageWithQ = "";
            string tmpWord = "";
            string word = "";
            foreach (char letter in message)
            {
                // Check if the word we are making so far is contained in our temporary string
                if (tmpWord.Contains(word + letter))
                {
                    word = word + letter;
                }
                // if our word is no longer contained in our temporary string, check if the temporary string ends with it
                else if (tmpWord.EndsWith(word) && tmpWord != "" && word.Length > 1)
                {
                    // Move our temporary string to the message with a Q since the last two words are the same
                    messageWithQ = messageWithQ + tmpWord + "Q" + word;
                    // Move the last word to the temporary string for furthur comparisons
                    tmpWord = "";
                    // Start a new word for compairing
                    word = letter.ToString();

                }
                // If the temporary string contained the word but didnt end with it, then we apend it without any Q
                else
                {
                    tmpWord = tmpWord + word;
                    word = letter.ToString();
                    if (messageWithQ.EndsWith(tmpWord) && messageWithQ != "")
                    {
                        // Move our temporary string to the message with a Q since the last two words are the same
                        messageWithQ = messageWithQ + "Q" + tmpWord;
                        // Start comparing a new word
                        tmpWord = word;
                        word = "";
                    }
                }
            }

            if (tmpWord != "")
            {
                if (messageWithQ.EndsWith(tmpWord))
                {
                    messageWithQ = messageWithQ + "Q" + tmpWord;
                }
                else
                {
                    messageWithQ = messageWithQ + tmpWord;
                }
            }

            if (word != "")
            {
                if (messageWithQ.EndsWith(word))
                {
                    messageWithQ = messageWithQ + "Q" + word;
                }
                else
                {
                    messageWithQ = messageWithQ + word;
                }
            }

            // Get an array of our message after one of its parsing iterations
            message = messageWithQ.ToArray();
            // Used to read the even and odd letter pairs within the message
            for (int i = 0; i < message.Length - 1; i++)
            {
                // If the letters repeat themselves
                if (message[i] == message[i + 1])
                {
                    message[i + 1] = Convert.ToChar("X");
                }
            }

            // Check if message has an even amount of letters
            if (message.Length % 2 == 1)
            {
                // If the message isn't an even number apend a "Q" at the end
                parsedMessage = message.ToList();
                parsedMessage.Insert(message.Length, Convert.ToChar("Q"));
                message = parsedMessage.ToArray();
            }
            
            return message;
        }

        public char[] cipher(char[] message)
        {
            int i = 0;
            int j = 1;
            for (; i < message.Length && j < message.Length;)
            {
                // Keeps track of the coresponding letters position in the table array 
                int evenNumberRow = -1;
                int evenNumberColumn = -1;
                int oddNumberRow = -1;
                int oddNumberColumn = -1;
                int foundLetters = 0;

                // Search table for positions of letters
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        if (table[k, l] == message[i])
                        {
                            evenNumberRow = k;
                            evenNumberColumn = l;
                            foundLetters++;
                        }
                        if (table[k, l] == message[j])
                        {
                            oddNumberRow = k;
                            oddNumberColumn = l;
                            foundLetters++;
                        }
                        // If we found both letters then stop the loops
                        if (foundLetters == 2) break;
                    }
                    if (foundLetters == 2) break;
                }

                // Check if letters are on the same row or column
                if (evenNumberRow == oddNumberRow)
                {
                    // Make sure the index overflows
                    message[i] = table[evenNumberRow, (evenNumberColumn + 1) % 5];
                    message[j] = table[oddNumberRow, (oddNumberColumn + 1) % 5];
                }
                else if (evenNumberColumn == oddNumberColumn)
                {
                    message[i] = table[(evenNumberRow + 1) % 5, evenNumberColumn];
                    message[j] = table[(oddNumberRow + 1) % 5, oddNumberColumn];
                }
                else
                {
                    message[i] = table[oddNumberRow, evenNumberColumn];
                    message[j] = table[evenNumberRow, oddNumberColumn];
                }

                // Iterate loop and start next pair
                i = i + 2;
                j = j + 2;
            }
            return message;
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
            char[] parsedMessage = parseText(message);
            char[] cipheredMessage = cipher(parsedMessage);
            txtResult.Text = "";
            for (int i = 0; i < cipheredMessage.Length; i++)
            {
                txtResult.Text = txtResult.Text + cipheredMessage[i].ToString();
            }
            //txtResult.Text = message.ToString();
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
            // Index of letter to add
            int resultLetter = -1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // J is not contained in the table and must be avoided
                    if (resultLetter == 8)
                    {
                        resultLetter = resultLetter + 2;
                    } else
                    {
                        resultLetter++;
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
