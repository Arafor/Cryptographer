using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private TextBox[] getTableTextBoxes()
        {
            TextBox[] tableTextBoxes = {
                txtTable00,
                txtTable01,
                txtTable02,
                txtTable03,
                txtTable04,
                txtTable10,
                txtTable11,
                txtTable12,
                txtTable13,
                txtTable14,
                txtTable20,
                txtTable21,
                txtTable22,
                txtTable23,
                txtTable24,
                txtTable30,
                txtTable31,
                txtTable32,
                txtTable33,
                txtTable34,
                txtTable40,
                txtTable41,
                txtTable42,
                txtTable43,
                txtTable44
            };
            return tableTextBoxes;
        }

        private char[] parseText(char[] message)
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

        private char[] cipher(char[] message, string function)
        {
            int i = 0;
            int j = 1;
            for (; i < message.Length && j < message.Length;)
            {
                // Keeps track of the coresponding letters position in the table array 
                int evenNumberY = -1;
                int evenNumberX = -1;
                int oddNumberY = -1;
                int oddNumberX = -1;
                int foundLetters = 0;

                // Search table for positions of letters
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        if (table[k, l] == message[i])
                        {
                            evenNumberY = k;
                            evenNumberX = l;
                            foundLetters++;
                        }
                        if (table[k, l] == message[j])
                        {
                            oddNumberY = k;
                            oddNumberX = l;
                            foundLetters++;
                        }
                        // If we found both letters then stop the loops
                        if (foundLetters == 2) break;
                    }
                    if (foundLetters == 2) break;
                }

                // Check if letters are on the same row or column
                if (evenNumberY == oddNumberY)
                {
                    if (function == "E")
                    {
                        // Make sure the index overflows
                        message[i] = table[evenNumberY, (evenNumberX + 1) % 5];
                        message[j] = table[oddNumberY, (oddNumberX + 1) % 5];
                    }
                    else if (function == "D")
                    {
                        // Make sure the index underflows
                        if (evenNumberX == 0) message[i] = table[evenNumberY, 5 - 1];
                        else message[i] = table[evenNumberY, (evenNumberX - 1) % 5];
                        if (oddNumberX == 0) message[j] = table[oddNumberY, 5 - 1];
                        else message[j] = table[oddNumberY, (oddNumberX - 1) % 5];
                    }
                }
                else if (evenNumberX == oddNumberX)
                {
                    if (function == "E")
                    {
                        message[i] = table[(evenNumberY + 1) % 5, evenNumberX];
                        message[j] = table[(oddNumberY + 1) % 5, oddNumberX];
                    }
                    else if (function == "D")
                    {
                        if (evenNumberY == 0) message[i] = table[5 - 1, evenNumberX];
                        else message[i] = table[(evenNumberY - 1) % 5, evenNumberX];
                        if (oddNumberY == 0) message[j] = table[5 - 1, oddNumberX];
                        else message[j] = table[(oddNumberY - 1) % 5, oddNumberX];
                    }
                }
                else
                {
                    message[i] = table[oddNumberY, evenNumberX];
                    message[j] = table[evenNumberY, oddNumberX];
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

        private void fillUITable()
        {
            // Fill UI table with letters from the table
            TextBox[] tableTextBoxes = getTableTextBoxes();
            int i = 0;
            foreach (TextBox txtBox in tableTextBoxes)
            {
                txtBox.Text = table[i/5, i%5].ToString();
                i++;
            }
        }

        private bool fillArrayTable()
        {
            // Check if the table contains all of the needed letters
            bool everythingOk = false;
            foreach (char letter in allowedLetters)
            {
                everythingOk = false;
                foreach (TextBox txtBox in getTableTextBoxes())
                {
                    if (txtBox.Text == "")
                    {
                        MessageBox.Show("Please fill in every square in the table");
                        break;
                    }
                    // Skip if a matching letter been found or if its J
                    else if (letter == Convert.ToChar("J") || letter == Convert.ToChar(txtBox.Text))
                    {
                        everythingOk = true;
                        break;
                    }
                }

                if (everythingOk)
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("The table does not contain all of the needed letters");
                    break;
                }
            }
            if (everythingOk)
            {
                try
                {
                    // Fill table with letters from the UI table
                    TextBox[] tableTextBoxes = getTableTextBoxes();
                    int i = 0;
                    foreach (TextBox txtBox in tableTextBoxes)
                    {
                        table[i / 5, i % 5] = txtBox.Text[0];
                        i++;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Please fill in the table!");
                }
            }

            return everythingOk;
        }

        private void tblTable_TextChanged(object sender, EventArgs e)
        {
            foreach (TextBox txtBox in getTableTextBoxes())
            {
                txtBox.CharacterCasing = CharacterCasing.Upper;
            }
        //    txtTable00.Text = txtTable00.Text.ToUpper();
        //    txtTable01.Text = txtTable01.Text.ToUpper();
        //    txtTable02.Text = txtTable02.Text.ToUpper();
        //    txtTable03.Text = txtTable03.Text.ToUpper();
        //    txtTable04.Text = txtTable04.Text.ToUpper();
        //    txtTable10.Text = txtTable10.Text.ToUpper();
        //    txtTable11.Text = txtTable11.Text.ToUpper();
        //    txtTable12.Text = txtTable12.Text.ToUpper();
        //    txtTable13.Text = txtTable13.Text.ToUpper();
        //    txtTable14.Text = txtTable14.Text.ToUpper();
        //    txtTable20.Text = txtTable20.Text.ToUpper();
        //    txtTable21.Text = txtTable21.Text.ToUpper();
        //    txtTable22.Text = txtTable22.Text.ToUpper();
        //    txtTable23.Text = txtTable23.Text.ToUpper();
        //    txtTable24.Text = txtTable24.Text.ToUpper();
        //    txtTable30.Text = txtTable30.Text.ToUpper();
        //    txtTable31.Text = txtTable31.Text.ToUpper();
        //    txtTable32.Text = txtTable32.Text.ToUpper();
        //    txtTable33.Text = txtTable33.Text.ToUpper();
        //    txtTable34.Text = txtTable34.Text.ToUpper();
        //    txtTable40.Text = txtTable40.Text.ToUpper();
        //    txtTable41.Text = txtTable41.Text.ToUpper();
        //    txtTable42.Text = txtTable42.Text.ToUpper();
        //    txtTable43.Text = txtTable43.Text.ToUpper();
        //    txtTable44.Text = txtTable44.Text.ToUpper();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Length > 0)
            {
                if (fillArrayTable())
                {
                    char[] message = txtMessage.Text.ToCharArray();
                    char[] parsedMessage = parseText(message);
                    char[] cipheredMessage = cipher(parsedMessage, "E");
                    txtResult.Text = "";
                    for (int i = 0; i < cipheredMessage.Length; i++)
                    {
                        txtResult.Text = txtResult.Text + cipheredMessage[i].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a message!");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Length > 0)
            {
                if (fillArrayTable())
                {
                    char[] message = txtMessage.Text.ToCharArray();
                    char[] cipheredMessage = cipher(message, "D");
                    txtResult.Text = "";
                    for (int i = 0; i < cipheredMessage.Length; i++)
                    {
                        txtResult.Text = txtResult.Text + cipheredMessage[i].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a message!");
            }
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
            txtMessage.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Fill table with imported letters
            TextBox[] tableTextBoxes = getTableTextBoxes();
            string letters = "";
            foreach (TextBox txtBox in tableTextBoxes)
            {
                letters = letters + txtBox.Text;
            }
            // Prepare SaveFileDialog for file saving 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "*.txt";
            saveFileDialog1.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save text to file";

            // If the file name is not an empty then save to file  
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                // Check if we need to create a new file
                if (!System.IO.File.Exists(saveFileDialog1.InitialDirectory + saveFileDialog1.FileName))
                {
                    FileStream fs = System.IO.File.Create(saveFileDialog1.InitialDirectory + saveFileDialog1.FileName);
                    fs.Close();
                }
                // Write to file
                File.WriteAllText(saveFileDialog1.InitialDirectory + saveFileDialog1.FileName, letters);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // Get the text from the chosen file
            int size = -1;
            string tableText = "";
            // Prepare and open the dialog window
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    tableText = File.ReadAllText(file);
                    size = tableText.Length;
                }
                catch (IOException)
                {
                }
            }
            // For debuging
            Console.WriteLine(size);
            Console.WriteLine(result);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (tableText.Length == 25)
                {
                    // Make sure contains all of the needed letters and only those
                    char[] tableTextCharArray = tableText.ToCharArray();
                    int j = 0;
                    bool containedLettersAreOk = true;
                    foreach (char letter in allowedLetters)
                    {
                        // Skip letter "J" since the table can not contain it
                        if (letter == Convert.ToChar("J")) continue;
                        for (j = 0; j < tableTextCharArray.Length; j++)
                        {
                            if (tableTextCharArray[j] == letter)
                            {
                                break;
                            }
                        }

                        if (j >= 25)
                        {
                            MessageBox.Show("The chosen file does not contain all of the necessary letters!");
                            containedLettersAreOk = false;
                            break;
                        }
                    }

                    if (containedLettersAreOk)
                    {
                        // Fill table with imported letters
                        TextBox[] tableTextBoxes = getTableTextBoxes();
                        int i = 0;
                        foreach (TextBox txtBox in tableTextBoxes)
                        {
                            txtBox.Text = tableTextCharArray[i].ToString();
                            i++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The chosen file does not contain 25 characters.\nPlease choose different file.");
                }
            }
        }
    }
}
