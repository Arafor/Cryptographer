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
    public partial class frmVigenere : frmVigenereBase
    {
        public frmVigenere()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
        }

        frmVigenereInfo vigenereInfo;

        private void btnSaveToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void btnVigenereInfo_Click(object sender, EventArgs e)
        {
            if (!vigenereInfo.Visible)
            {
                vigenereInfo = new frmVigenereInfo();
                vigenereInfo.Show();
                if (txtMessage.Text != "" && txtKey.Text != "")
                {
                    vigenereInfo.setMessageAndKey(txtMessage.Text, txtKey.Text);
                }
                this.Close();
            }
        }

        private void frmVigenere_Load(object sender, EventArgs e)
        {
            rdoBtnEncrypt.Checked = true;
            vigenereInfo = new frmVigenereInfo();
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields(txtMessage.Text, txtKey.Text))
            {
                // Prepare to display result
                txtResult.Text = "";
                int[] message = prepareTextToCipher(txtMessage.Text);
                int[] key = prepareKeytoCipher(txtKey.Text, message.Length);
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
        }

        private void frmVigenere_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmVigenereInfo vigenereInfo = new frmVigenereInfo();
            vigenereInfo.Close();
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
    }
}
