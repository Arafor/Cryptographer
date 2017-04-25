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
    public partial class frmCaesarInfo : Form
    {
        public frmCaesarInfo()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCaesar formCaesar = new frmCaesar();
            formWindowManager.setFormWindowLocation(formCaesar, this);
        }

        frmCaesar caesar = new frmCaesar();
        NumericalAlphabet numAlphabet = new NumericalAlphabet();

        private void frmCaesarInfo_Load(object sender, EventArgs e)
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
                "" };
            if (rdoBtnEncrypt.Checked)
            {
                formulaMessage.Add("(P + K) > 0: C = P + K (mod 26)");
                formulaMessage.Add("(P + K) < 0: C = 26 + (P + K (mod 26))");
                lblMessage.Text = "Plaintext";
                lblResult.Text = "Ciphertext";
            }
            else if (rdoBtnDecrypt.Checked)
            {
                formulaMessage.Add("(P + K) > 0: P = C - K (mod 26)");
                formulaMessage.Add("(P + K) < 0: P = 26 + (C - K (mod 26))");
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
            txtResult.Text = "";
            if (caesar.checkEmptyFields(txtMessage.Text, txtKey.Text))
            {
                try
                {
                    if (rdoBtnEncrypt.Checked)
                    {
                        txtResult.Text = caesar.cipher(caesar.getParsedMessage(txtMessage.Text), caesar.getParsedKey(txtKey.Text), "E");
                    }
                    else if (rdoBtnDecrypt.Checked)
                    {
                        txtResult.Text = caesar.cipher(caesar.getParsedMessage(txtMessage.Text), caesar.getParsedKey(txtKey.Text), "D");
                    }
                    else
                    {
                        MessageBox.Show("Select if you want to encrypt or decrypt the text");
                    }
                    if (txtResult.Text != "")
                    {
                        txtMessageParsed.Text = new string(numAlphabet.numbersToLetters(caesar.getParsedMessage(txtMessage.Text)));
                        //txtKeyParsed.Text = new string(caesar.createPaddedKey(txtKey.Text.ToCharArray(), txtMessage.Text.Length)).ToUpper();
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
