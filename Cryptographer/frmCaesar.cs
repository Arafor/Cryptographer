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
    public partial class frmCaesar : frmCaesarBase
    {
        public frmCaesar()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
            this.ActiveControl = txtMessage;
        }

        frmCaesarInfo caesarInfo;

        private void btnSaveToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void btnCaesarInfo_Click(object sender, EventArgs e)
        {
            if (!caesarInfo.Visible)
            {
                caesarInfo = new frmCaesarInfo();
                caesarInfo.Show();
                if (txtMessage.Text != "" && txtKey.Text != "")
                {
                    caesarInfo.setMessageAndKey(txtMessage.Text, txtKey.Text);
                }
                this.Close();
            }
        }

        private void frmCaesar_Load(object sender, EventArgs e)
        {
            rdoBtnEncrypt.Checked = true;
            caesarInfo = new frmCaesarInfo();
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields(txtMessage.Text, txtKey.Text))
            {
                // Prepare for cipher text display
                txtResult.Text = "";
                int[] message = getParsedMessage(txtMessage.Text);
                int key = getParsedKey(txtKey.Text);
                if (message != null)
                {
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
                else
                {
                    MessageBox.Show("Please use only letters from the english alphabet (A-Z)!");
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

        private void frmCaesar_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmCaesar ceasarCipher = new frmCaesar();
            ceasarCipher.Close();
        }
    }
}
