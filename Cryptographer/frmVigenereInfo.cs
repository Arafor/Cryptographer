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
    public partial class frmVigenereInfo : frmVigenereBase
    {
        public frmVigenereInfo()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
        }

        frmVigenere vigenere;
        NumericalAlphabet numAlphabet = new NumericalAlphabet();

        private void frmVigenereInfo_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (char letter in numAlphabet.getAlphabet())
            {
                lstAlphabet.Items.Add(i + " => " + letter);
                i++;
            }
            rdoBtnEncrypt.Checked = true;
            vigenere = new frmVigenere();
        }

        private void cipherRadioButtonChanged(object sender, EventArgs e)
        {
            lstFormula.Items.Clear();
            List<string> formulaMessage = new List<string>{
                "P- plaintext letter, ",
                "C- ciphertext letter, ",
                "K- key letter, ",
                "a- the number of what letter in order it is from the message or ciphertext, ",
                "b- the number of what letter in order it is from the key",
                "" };
            if (rdoBtnEncrypt.Checked)
            {
                formulaMessage.Add("Ca = Pa + Kb (mod 26)");
                lblMessage.Text = "Plaintext";
                lblResult.Text = "Ciphertext";
            }
            else if (rdoBtnDecrypt.Checked)
            {
                formulaMessage.Add("Pa = (26 + (Ca - Kb)) (mod 26)");
                lblMessage.Text = "Ciphertext";
                lblResult.Text = "Plaintext";
            }
            else
            {
                MessageBox.Show("Select if you want to encrypt or decrypt the text");
            }
            foreach (string line in formulaMessage)
            {
                lstFormula.Items.Add(line);
            }
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            txtMessageParsed.Text = "";
            txtKeyParsed.Text = "";
            txtResult.Text = "";
            if (checkEmptyFields(txtMessage.Text, txtKey.Text))
            {
                try
                {
                    int[] message = prepareTextToCipher(txtMessage.Text);
                    if (rdoBtnEncrypt.Checked)
                    {
                        txtResult.Text = cipher(message, prepareKeytoCipher(txtKey.Text, message.Length), "E");
                    }
                    else if (rdoBtnDecrypt.Checked)
                    {
                        txtResult.Text = cipher(message, prepareKeytoCipher(txtKey.Text, message.Length), "D");
                    }
                    else
                    {
                        MessageBox.Show("Select if you want to encrypt or decrypt the text");
                    }
                    if (txtResult.Text != "")
                    {
                        TextParser textParser = new TextParser();
                        txtMessageParsed.Text = new string(textParser.parseReplaceableLetters(txtMessage.Text.ToUpper().ToCharArray())).ToUpper();
                        txtKeyParsed.Text = new string(createPaddedKey(textParser.parseReplaceableLetters(txtKey.Text.ToCharArray()), txtMessageParsed.Text.Length)).ToUpper();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            if (!vigenere.Visible)
            {
                vigenere = new frmVigenere();
                vigenere.Show();
                if (txtMessage.Text != "" && txtKey.Text != "")
                {
                    vigenere.setMessageAndKey(txtMessage.Text, txtKey.Text);
                }
                this.Close();
            }
        }

        private void frmVigenereInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmVigenere vigenere = new frmVigenere();
            vigenere.Close();
        }
    }
}
