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

        private void frmVigenere_Load(object sender, EventArgs e)
        {

        }

        // Arrays containing values from textboxes
        char[] plaintextArray;
        char[] keyArray;
        char[] paddedKeyArray;
        char[] ciphertextArray;

        int[] CipherTextTempArray;
        int[] PlainTextTempArray;
        int[] KeyTextTempArray;

        // Lengths of textbox string
        int plaintextStringLength;
        int keyStringLength;
        int ciphertextStringLength;

        string PlainTextString;
        string KeyString;
        string CipherTextString;

        bool everythingOk;


        NumericalAlphabet numAlphabet = new NumericalAlphabet();

        public Boolean checkEmptyFields()
        {
            if (txtKey.Text.Length > 0)
            {
                if (txtPlaintext.Text.Length > 0 || txtCiphertext.Text.Length > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Lūdzu ievadiet ziņu!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Atslēga nedrīkst būt tukša!");
                return false;
            }
        }

        public void createPaddedKey()
        {
           /* if (k == 1)
            {*/
                //creates the key at plaintext length
                //makes sure fields arent left empty
                /*if (txtKey.Text.Length > 0)
                {
                    if (txtPlaintext.Text.Length > 0 || txtCiphertext.Text.Length > 0)
                    {*/
                        int j = 0;
                        for (int i = 0; i < paddedKeyArray.Length; i++)
                        {
                            if (j >= keyArray.Length)
                            {
                                j = 0;
                            }
                            paddedKeyArray[i] = keyArray[j];
                            j++;
                        }
                    /*}
                    else
                    {
                        MessageBox.Show("Plaintext nedrīkst būt tukšs!");
                    }
                }
                else
                {
                    MessageBox.Show("Atslēga nedrīkst būt tukša!");
                }*/
            //}
            /*else if (k == 2)
            {
                //creates the key at ciphertext length
                //makes sure fields arent left empty
                if (txtKey.Text.Length > 0)
                {
                    if (txtCiphertext.Text.Length > 0)
                    {
                        int j = 0;
                        for (int i = 0; i < paddedKeyArray.Length; i++)
                        {
                            if (j >= keyArray.Length)
                            {
                                j = 0;
                            }
                            paddedKeyArray[i] = keyArray[j];
                            j++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ciphertext nedrīkst būt tukšs!");
                    }
                }
                else
                {
                    MessageBox.Show("Atslēga nedrīkst būt tukša!");
                }
            }*/
        }

        public String cipher(int[] message, int[] key, string function)
        {
            // Create variables used withing the method
            int[] resultMessageInInt = new int[message.Length];
            int a;
            int b;
            int c = numAlphabet.alphabetLength();
            int result = 0;

            // Create the numeric array of the ciphertext
            for (int i = 0; i < paddedKeyArray.Length; i++)
            {
                a = message[i];
                b = key[i];
                if (function == "E")
                {
                    result = ((a + b) % c);
                }
                else if (function == "D")
                {
                    result = ((c + (a - b)) % c);
                }
                resultMessageInInt[i] = result;
            }

            // Get the ciphertext in string
            char[] resultMessageInChar = numAlphabet.numbersToLetters(resultMessageInInt);
            string resultMessageInString = "";
            for (int i = 0; i < resultMessageInChar.Length; i++)
            {
                resultMessageInString = resultMessageInString + resultMessageInChar[i].ToString();
            }

            return resultMessageInString;
        }

        /*public void decrypt()
        {
            PlainTextTempArray = new int[ciphertextArray.Length];
            for (int i = 0; i < paddedKeyArray.Length; i++)
            {
                int a = CipherTextTempArray[i];
                int b = KeyTextTempArray[i];
                int c = 26;
                int result = 0;
                if (a - b < 0)
                {
                    result = ((c + (a - b)) % c);
                }
                else
                {
                    result = ((a - b) % c);
                }
                PlainTextTempArray[i] = result;
            }
            getLetters(2);
            for (int i = 0; i < plaintextArray.Length; i++)
            {
                PlainTextString = PlainTextString + plaintextArray[i].ToString();
            }
            txtPlaintext.Text = PlainTextString;
        }*/

        public void letterCheck(int n)
        {
            everythingOk = true;
            if (n == 1)
            {
                PlainTextTempArray = new int[plaintextStringLength];
                try
                {
                    for (int i = 0; i < plaintextStringLength; i++)
                    {
                        if (!everythingOk)
                        {
                            break;
                        }
                        if (plaintextArray[i] == 'A')
                        {
                            PlainTextTempArray[i] = 0;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("B"))
                        {
                            PlainTextTempArray[i] = 1;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("C"))
                        {
                            PlainTextTempArray[i] = 2;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("D"))
                        {
                            PlainTextTempArray[i] = 3;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("E"))
                        {
                            PlainTextTempArray[i] = 4;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("F"))
                        {
                            PlainTextTempArray[i] = 5;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("G"))
                        {
                            PlainTextTempArray[i] = 6;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("H"))
                        {
                            PlainTextTempArray[i] = 7;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("I"))
                        {
                            PlainTextTempArray[i] = 8;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("J"))
                        {
                            PlainTextTempArray[i] = 9;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("K"))
                        {
                            PlainTextTempArray[i] = 10;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("L"))
                        {
                            PlainTextTempArray[i] = 11;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("M"))
                        {
                            PlainTextTempArray[i] = 12;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("N"))
                        {
                            PlainTextTempArray[i] = 13;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("O"))
                        {
                            PlainTextTempArray[i] = 14;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("P"))
                        {
                            PlainTextTempArray[i] = 15;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("Q"))
                        {
                            PlainTextTempArray[i] = 16;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("R"))
                        {
                            PlainTextTempArray[i] = 17;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("S"))
                        {
                            PlainTextTempArray[i] = 18;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("T"))
                        {
                            PlainTextTempArray[i] = 19;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("U"))
                        {
                            PlainTextTempArray[i] = 20;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("V"))
                        {
                            PlainTextTempArray[i] = 21;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("W"))
                        {
                            PlainTextTempArray[i] = 22;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("X"))
                        {
                            PlainTextTempArray[i] = 23;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("Y"))
                        {
                            PlainTextTempArray[i] = 24;
                        }
                        else if (plaintextArray[i] == Convert.ToChar("Z"))
                        {
                            PlainTextTempArray[i] = 25;
                        }
                        else
                        {
                            everythingOk = false;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            else if (n == 2)
            {
                CipherTextTempArray = new int[ciphertextStringLength];
                for (int i = 0; i < ciphertextStringLength; i++)
                {
                    if (!everythingOk)
                    {
                        break;
                    }
                    if (ciphertextArray[i] == Convert.ToChar("A"))
                    {
                        CipherTextTempArray[i] = 0;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("B"))
                    {
                        CipherTextTempArray[i] = 1;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("C"))
                    {
                        CipherTextTempArray[i] = 2;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("D"))
                    {
                        CipherTextTempArray[i] = 3;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("E"))
                    {
                        CipherTextTempArray[i] = 4;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("F"))
                    {
                        CipherTextTempArray[i] = 5;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("G"))
                    {
                        CipherTextTempArray[i] = 6;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("H"))
                    {
                        CipherTextTempArray[i] = 7;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("I"))
                    {
                        CipherTextTempArray[i] = 8;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("J"))
                    {
                        CipherTextTempArray[i] = 9;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("K"))
                    {
                        CipherTextTempArray[i] = 10;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("L"))
                    {
                        CipherTextTempArray[i] = 11;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("M"))
                    {
                        CipherTextTempArray[i] = 12;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("N"))
                    {
                        CipherTextTempArray[i] = 13;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("O"))
                    {
                        CipherTextTempArray[i] = 14;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("P"))
                    {
                        CipherTextTempArray[i] = 15;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("Q"))
                    {
                        CipherTextTempArray[i] = 16;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("R"))
                    {
                        CipherTextTempArray[i] = 17;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("S"))
                    {
                        CipherTextTempArray[i] = 18;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("T"))
                    {
                        CipherTextTempArray[i] = 19;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("U"))
                    {
                        CipherTextTempArray[i] = 20;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("V"))
                    {
                        CipherTextTempArray[i] = 21;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("W"))
                    {
                        CipherTextTempArray[i] = 22;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("X"))
                    {
                        CipherTextTempArray[i] = 23;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("Y"))
                    {
                        CipherTextTempArray[i] = 24;
                    }
                    else if (ciphertextArray[i] == Convert.ToChar("Z"))
                    {
                        CipherTextTempArray[i] = 25;
                    }
                    else
                    {
                        everythingOk = false;
                    }
                }
            }
            else if (n == 3)
            {
                KeyTextTempArray = new int[paddedKeyArray.Length];
                for (int i = 0; i < paddedKeyArray.Length; i++)
                {
                    if (!everythingOk)
                    {
                        break;
                    }
                    if (paddedKeyArray[i] == Convert.ToChar("A"))
                    {
                        KeyTextTempArray[i] = 0;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("B"))
                    {
                        KeyTextTempArray[i] = 1;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("C"))
                    {
                        KeyTextTempArray[i] = 2;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("D"))
                    {
                        KeyTextTempArray[i] = 3;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("E"))
                    {
                        KeyTextTempArray[i] = 4;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("F"))
                    {
                        KeyTextTempArray[i] = 5;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("G"))
                    {
                        KeyTextTempArray[i] = 6;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("H"))
                    {
                        KeyTextTempArray[i] = 7;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("I"))
                    {
                        KeyTextTempArray[i] = 8;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("J"))
                    {
                        KeyTextTempArray[i] = 9;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("K"))
                    {
                        KeyTextTempArray[i] = 10;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("L"))
                    {
                        KeyTextTempArray[i] = 11;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("M"))
                    {
                        KeyTextTempArray[i] = 12;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("N"))
                    {
                        KeyTextTempArray[i] = 13;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("O"))
                    {
                        KeyTextTempArray[i] = 14;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("P"))
                    {
                        KeyTextTempArray[i] = 15;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("Q"))
                    {
                        KeyTextTempArray[i] = 16;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("R"))
                    {
                        KeyTextTempArray[i] = 17;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("S"))
                    {
                        KeyTextTempArray[i] = 18;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("T"))
                    {
                        KeyTextTempArray[i] = 19;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("U"))
                    {
                        KeyTextTempArray[i] = 20;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("V"))
                    {
                        KeyTextTempArray[i] = 21;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("W"))
                    {
                        KeyTextTempArray[i] = 22;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("X"))
                    {
                        KeyTextTempArray[i] = 23;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("Y"))
                    {
                        KeyTextTempArray[i] = 24;
                    }
                    else if (paddedKeyArray[i] == Convert.ToChar("Z"))
                    {
                        KeyTextTempArray[i] = 25;
                    }
                    else
                    {
                        everythingOk = false;
                    }
                }
            }
        }

        public void getLetters(int n)
        {
            int[] IntTempArray;
            IntTempArray = new int[1];
            char[] CharTempArray;
            if (n == 1)
            {
                IntTempArray = CipherTextTempArray;
            }
            else if (n == 2)
            {
                IntTempArray = PlainTextTempArray;
            }
            CharTempArray = new char[IntTempArray.Length];
            try
            {
                for (int i = 0; i < IntTempArray.Length; i++)
                {
                    if (!everythingOk)
                    {
                        break;
                    }
                    if (IntTempArray[i] == 0)
                    {
                        CharTempArray[i] = 'A';
                        //MessageBox.Show("OK");
                    }
                    else if (IntTempArray[i] == 1)
                    {
                        CharTempArray[i] = 'B';
                    }
                    else if (IntTempArray[i] == 2)
                    {
                        CharTempArray[i] = 'C';
                    }
                    else if (IntTempArray[i] == 3)
                    {
                        CharTempArray[i] = 'D';
                    }
                    else if (IntTempArray[i] == 4)
                    {
                        CharTempArray[i] = 'E';
                    }
                    else if (IntTempArray[i] == 5)
                    {
                        CharTempArray[i] = 'F';
                    }
                    else if (IntTempArray[i] == 6)
                    {
                        CharTempArray[i] = 'G';
                    }
                    else if (IntTempArray[i] == 7)
                    {
                        CharTempArray[i] = 'H';
                    }
                    else if (IntTempArray[i] == 8)
                    {
                        CharTempArray[i] = 'I';
                    }
                    else if (IntTempArray[i] == 9)
                    {
                        CharTempArray[i] = 'J';
                    }
                    else if (IntTempArray[i] == 10)
                    {
                        CharTempArray[i] = 'K';
                    }
                    else if (IntTempArray[i] == 11)
                    {
                        CharTempArray[i] = 'L';
                    }
                    else if (IntTempArray[i] == 12)
                    {
                        CharTempArray[i] = 'M';
                    }
                    else if (IntTempArray[i] == 13)
                    {
                        CharTempArray[i] = 'N';
                    }
                    else if (IntTempArray[i] == 14)
                    {
                        CharTempArray[i] = 'O';
                    }
                    else if (IntTempArray[i] == 15)
                    {
                        CharTempArray[i] = 'P';
                    }
                    else if (IntTempArray[i] == 16)
                    {
                        CharTempArray[i] = 'Q';
                    }
                    else if (IntTempArray[i] == 17)
                    {
                        CharTempArray[i] = 'R';
                    }
                    else if (IntTempArray[i] == 18)
                    {
                        CharTempArray[i] = 'S';
                    }
                    else if (IntTempArray[i] == 19)
                    {
                        CharTempArray[i] = 'T';
                    }
                    else if (IntTempArray[i] == 20)
                    {
                        CharTempArray[i] = 'U';
                    }
                    else if (IntTempArray[i] == 21)
                    {
                        CharTempArray[i] = 'V';
                    }
                    else if (IntTempArray[i] == 22)
                    {
                        CharTempArray[i] = 'W';
                    }
                    else if (IntTempArray[i] == 23)
                    {
                        CharTempArray[i] = 'X';
                    }
                    else if (IntTempArray[i] == 24)
                    {
                        CharTempArray[i] = 'Y';
                    }
                    else if (IntTempArray[i] == 25)
                    {
                        CharTempArray[i] = 'Z';
                    }
                    else
                    {
                        everythingOk = false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            if (n == 1)
            {

                ciphertextArray = CharTempArray;
            }
            else if (n == 2)
            {
                plaintextArray = CharTempArray;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Prepare for cipher text display
            KeyTextTempArray = new int[1];
            txtCiphertext.Text = "";
            CipherTextString = "";
            if (checkEmptyFields())
            {
                // Get plaintext and key with lengths
                plaintextStringLength = txtPlaintext.Text.Length;
                keyStringLength = txtKey.Text.Length;
                plaintextArray = txtPlaintext.Text.ToCharArray();
                keyArray = txtKey.Text.ToArray();

                // Create padded key
                paddedKeyArray = new char[plaintextStringLength];
                createPaddedKey();

                // Translate message and key to numerical values
                int[] message = numAlphabet.lettersToNumbers(plaintextArray);
                int[] numericKey = numAlphabet.lettersToNumbers(paddedKeyArray);
                if (message != null || numericKey != null)
                {
                    cipher(message, numericKey, "E");
                } else
                {
                    MessageBox.Show("Lūdzu izmantojiet tekstā tikai latīņu burtus no A līdz Z!");
                }


                /*letterCheck(1);
                if (everythingOk)
                {
                    createPaddedKey(1);
                    letterCheck(3);
                    if (everythingOk)
                    {
                        Encrypt();
                    }
                }*/
                //Converts array to displayable string
                KeyString = new string(paddedKeyArray);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            KeyTextTempArray = new int[1];
            txtPlaintext.Text = "";
            PlainTextString = "";
            ciphertextStringLength = txtCiphertext.Text.Length;
            keyStringLength = txtKey.Text.Length;
            ciphertextArray = txtCiphertext.Text.ToCharArray();
            keyArray = txtKey.Text.ToArray();
            paddedKeyArray = new char[ciphertextStringLength];
            letterCheck(2);
            if (everythingOk)
            {
                createPaddedKey(2);
                letterCheck(3);

                if (everythingOk)
                {
                    decrypt();
                }
            }
            //Converts array to displayable string
            KeyString = new string(paddedKeyArray);
        }
    }
}
