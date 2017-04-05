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
        FileManager fileManager = new FileManager();
        NumericalAlphabet numAlphabet = new NumericalAlphabet();

        protected TextBox[] getTableTextBoxes()
        {
            try
            {
                TextBox[] tableTextBoxes = {
                    this.txtTable00,
                    this.txtTable01,
                    this.txtTable02,
                    this.txtTable03,
                    this.txtTable04,
                    this.txtTable10,
                    this.txtTable11,
                    this.txtTable12,
                    this.txtTable13,
                    this.txtTable14,
                    this.txtTable20,
                    this.txtTable21,
                    this.txtTable22,
                    this.txtTable23,
                    this.txtTable24,
                    this.txtTable30,
                    this.txtTable31,
                    this.txtTable32,
                    this.txtTable33,
                    this.txtTable34,
                    this.txtTable40,
                    this.txtTable41,
                    this.txtTable42,
                    this.txtTable43,
                    this.txtTable44
                };

                return tableTextBoxes;
            } catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

                return null;
            }
        }

        protected char[] parseText(char[] message)
        {
            TextParser txtParser = new TextParser();
            message = txtParser.parseReplaceableLetters(message);
            if (txtParser.checkAllowedLetters(message))
            {
                message = messageReplaceJWithI(message);
                message = messageInsertQ(message);
                message = messageAppendQ(message);
                message = messageReplaceWithX(message);

                return message;
            }

            return null;
        }

        private char[] messageReplaceJWithI(char[] message)
        {
            // List holds parsed message (valid letters, without unnecessary symbols)
            var parsedMessage = new List<char>();
            // Iterate through our current message
            for (int i = 0; i < message.Length; i++)
            {
                // Replace letter "J" with "I"
                if (message[i] == Convert.ToChar("J"))
                {
                    parsedMessage.Insert(i, Convert.ToChar("I"));
                }
                else
                {
                    parsedMessage.Insert(i, message[i]);
                }
            }

            return parsedMessage.ToArray();
        }

        private char[] messageInsertQ(char[] message)
        {
            // Insert Q between repeating words
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
            return messageWithQ.ToArray();
        }

        private char[] messageAppendQ(char[] message)
        {
            var parsedMessage = new List<char>();
            // Check if message has an even amount of letters
            if (message.Length % 2 == 1)
            {
                // If the message isn't an even number apend a "Q" at the end
                parsedMessage = message.ToList();
                parsedMessage.Insert(message.Length, Convert.ToChar("Q"));
                message = parsedMessage.ToArray();
            }

            return parsedMessage.ToArray();
        }

        private char[] messageReplaceWithX(char[] message)
        {
            // Used to read the even and odd letter pairs within the message
            for (int i = 0; i < message.Length - 1; i++)
            {
                // If the letters repeat themselves
                if (message[i] == message[i + 1])
                {
                    message[i + 1] = Convert.ToChar("X");
                }
            }

            return message;
        }

        protected string cipher(char[] message, string function)
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
                char[,] tableArray = getTableArray(getTableTextBoxes());

                // Search table for positions of letters
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        if (tableArray[k, l] == message[i])
                        {
                            evenNumberY = k;
                            evenNumberX = l;
                            foundLetters++;
                        }
                        if (tableArray[k, l] == message[j])
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
                        message[i] = tableArray[evenNumberY, (evenNumberX + 1) % 5];
                        message[j] = tableArray[oddNumberY, (oddNumberX + 1) % 5];
                    }
                    else if (function == "D")
                    {
                        // Make sure the index underflows
                        if (evenNumberX == 0) message[i] = tableArray[evenNumberY, 5 - 1];
                        else message[i] = tableArray[evenNumberY, (evenNumberX - 1) % 5];
                        if (oddNumberX == 0) message[j] = tableArray[oddNumberY, 5 - 1];
                        else message[j] = tableArray[oddNumberY, (oddNumberX - 1) % 5];
                    }
                }
                else if (evenNumberX == oddNumberX)
                {
                    if (function == "E")
                    {
                        message[i] = tableArray[(evenNumberY + 1) % 5, evenNumberX];
                        message[j] = tableArray[(oddNumberY + 1) % 5, oddNumberX];
                    }
                    else if (function == "D")
                    {
                        if (evenNumberY == 0) message[i] = tableArray[5 - 1, evenNumberX];
                        else message[i] = tableArray[(evenNumberY - 1) % 5, evenNumberX];
                        if (oddNumberY == 0) message[j] = tableArray[5 - 1, oddNumberX];
                        else message[j] = tableArray[(oddNumberY - 1) % 5, oddNumberX];
                    }
                }
                else
                {
                    message[i] = tableArray[oddNumberY, evenNumberX];
                    message[j] = tableArray[evenNumberY, oddNumberX];
                }

                // Iterate loop and start next pair
                i = i + 2;
                j = j + 2;
            }

            string messageString = "";
            for (int n = 0; n < message.Length; n++)
            {
                messageString = messageString + message[n].ToString();
            }

            return messageString;
        }

        public frmPlayfair()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
        }

        protected void fillUITable(TextBox[] tableTextBoxes, char[,] tableArray)
        {
            // Fill UI table with letters from the table
            int i = 0;
            foreach (TextBox txtBox in tableTextBoxes)
            {
                txtBox.Text = tableArray[i/5, i%5].ToString();
                i++;
            }
        }

        public char[,] getTableArray(TextBox[] tableTextBoxes)
        {
            if (checkTableContent())
            {
                // Fill the array table with letters from the UI table
                char[,] tableArray = new char[5, 5];
                int i = 0;
                foreach (TextBox txtBox in tableTextBoxes)
                {
                    tableArray[i / 5, i % 5] = txtBox.Text[0];
                    i++;
                }

                return tableArray;
            }

            return null;
        }

        public bool checkTableContent()
        {
            // Check if the table contains all of the needed letters
            bool everythingOk = false;
            foreach (char letter in numAlphabet.getAlphabet())
            {
                everythingOk = false;
                foreach (TextBox txtBox in getTableTextBoxes())
                {
                    if (txtBox.Text == "")
                    {
                        MessageBox.Show("Please fill in every square in the table");
                        break;
                    }
                    // Skip if the letter matches to the needed letter or to the letter J
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

            return everythingOk;
        }

        private void tblTable_TextChanged(object sender, EventArgs e)
        {
            foreach (TextBox txtBox in getTableTextBoxes())
            {
                txtBox.CharacterCasing = CharacterCasing.Upper;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Length > 0)
            {
                if (checkTableContent())
                {
                    char[] parsedMessage = parseText(txtMessage.Text.ToCharArray());
                    if (parsedMessage != null)
                    {
                        txtResult.Text = "";
                        txtResult.Text = cipher(parsedMessage, "E");
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
                if (checkTableContent())
                {
                    char[] parsedMessage = parseText(txtMessage.Text.ToCharArray());
                    if (parsedMessage != null)
                    {
                        txtResult.Text = "";
                        txtResult.Text = cipher(parsedMessage, "D");

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
            foreach (TextBox txtBox in getTableTextBoxes())
            {
                txtBox.Text = "";
            }
        }

        private void btnAutoFill_Click(object sender, EventArgs e)
        {
            // Index of letter to add
            int resultLetter = -1;
            char[] alphabetLetters = numAlphabet.getAlphabet();
            char[,] tableArray = new char[5, 5];
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
                    tableArray[i, j] = alphabetLetters[resultLetter];
                }
            }
            fillUITable(getTableTextBoxes(), tableArray);
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
            MessageBox.Show("The information that the table contains must remain secret!\nYour encrypted messages can be easilly decrypted if someone has your table.");
            // Fill table with imported letters
            TextBox[] tableTextBoxes = getTableTextBoxes();
            string letters = "";
            foreach (TextBox txtBox in tableTextBoxes)
            {
                letters = letters + txtBox.Text;
            }

            fileManager.exportFile(letters);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // Get file content
            string file = fileManager.importFile();
            string fileContent = fileManager.getFileContent(file);
            int fileContentLength = fileContent.Length;

            // The file must contain exactly 25 letters for the table
            if (fileContent.Length == 25)
            {
                // Make sure the imported text contains all of the necessary letters
                char[] fileContentCharArray = fileContent.ToCharArray();
                int j = 0;
                bool containedLettersAreOk = true;
                foreach (char letter in numAlphabet.getAlphabet())
                {
                    // Skip letter "J" since the table can not contain it
                    if (letter == Convert.ToChar("J")) continue;
                    for (j = 0; j < fileContentCharArray.Length; j++)
                    {
                        if (fileContentCharArray[j] == letter)
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
                        txtBox.Text = fileContentCharArray[i].ToString();
                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("The chosen file does not contain 25 characters.\nPlease choose a different file.");
            }

        }

        private void btnVigenereInfo_Click(object sender, EventArgs e)
        {

            frmPlayfairInfo playfairInfo = new frmPlayfairInfo();
            playfairInfo.Show();
            if (txtMessage.Text != "" && getTableArray(getTableTextBoxes()) != null)
            {
                playfairInfo.setMessageAndTable(txtMessage.Text, getTableArray(getTableTextBoxes()));
            }
        }
    }
}
