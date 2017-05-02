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
    public partial class frmCaesarInfo : frmCaesarBase
    {
        public frmCaesarInfo()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
            this.ActiveControl = txtMessage;
        }

        NumericalAlphabet numAlphabet = new NumericalAlphabet();
        frmCaesar caesar;

        private void frmCaesarInfo_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (char letter in numAlphabet.getAlphabet())
            {
                lstAlphabet.Items.Add(i + " => " + letter);
                i++;
            }
            rdoBtnEncrypt.Checked = true;
            caesar = new frmCaesar();
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
            if (checkEmptyFields(txtMessage.Text, txtKey.Text))
            {
                try
                {
                    if (rdoBtnEncrypt.Checked)
                    {
                        txtResult.Text = cipher(getParsedMessage(txtMessage.Text), getParsedKey(txtKey.Text), "E");
                    }
                    else if (rdoBtnDecrypt.Checked)
                    {
                        txtResult.Text = cipher(getParsedMessage(txtMessage.Text), getParsedKey(txtKey.Text), "D");
                    }
                    else
                    {
                        MessageBox.Show("Select if you want to encrypt or decrypt the text");
                    }
                    if (txtResult.Text != "")
                    {
                        txtMessageParsed.Text = new string(numAlphabet.numbersToLetters(getParsedMessage(txtMessage.Text)));
                        //txtKeyParsed.Text = new string(caesar.createPaddedKey(txtKey.Text.ToCharArray(), txtMessage.Text.Length)).ToUpper();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

        private void btnCaesarInfo_Click(object sender, EventArgs e)
        {
            if (!caesar.Visible)
            {
                caesar = new frmCaesar();
                caesar.Show();
                if (txtMessage.Text != "" && txtKey.Text != "")
                {
                    caesar.setMessageAndKey(txtMessage.Text, txtKey.Text);
                }
                this.Close();
            }
        }

        private void frmCaesarInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmCaesar ceasarCipher = new frmCaesar();
            ceasarCipher.Close();
        }
    }
}
