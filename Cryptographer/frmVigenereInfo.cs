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
    public partial class frmVigenereInfo : Form
    {
        public frmVigenereInfo()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmVigenere formVigenere = new frmVigenere();
            formWindowManager.setFormWindowLocation(formVigenere, this);
        }

        frmVigenere vigenere = new frmVigenere();
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
        }

        public void setMessageAndKey(string message, string key)
        {
            txtMessage.Text = message;
            txtKey.Text = key;
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
            if (vigenere.checkEmptyFields(txtMessage.Text, txtKey.Text))
            {
                try
                {
                    if (rdoBtnEncrypt.Checked)
                    {
                        txtResult.Text = vigenere.cipher(vigenere.prepareTextToCipher(txtMessage.Text), vigenere.prepareKeytoCipher(txtKey.Text, txtMessage.Text.Length), "E");
                    }
                    else if (rdoBtnDecrypt.Checked)
                    {
                        txtResult.Text = vigenere.cipher(vigenere.prepareTextToCipher(txtMessage.Text), vigenere.prepareKeytoCipher(txtKey.Text, txtMessage.Text.Length), "D");
                    }
                    else
                    {
                        MessageBox.Show("Select if you want to encrypt or decrypt the text");
                    }
                    if (txtResult.Text != "")
                    {
                        txtMessageParsed.Text = txtMessage.Text.ToUpper();
                        txtKeyParsed.Text = new string(vigenere.createPaddedKey(txtKey.Text.ToCharArray(), txtMessage.Text.Length)).ToUpper();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }
    }
}
