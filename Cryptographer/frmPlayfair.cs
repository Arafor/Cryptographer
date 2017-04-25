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
    public partial class frmPlayfair : frmPlayfairBase
    {
        public frmPlayfair()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
        }

        private void btnSaveToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void btnVigenereInfo_Click(object sender, EventArgs e)
        {
            frmPlayfairInfo playfairInfo = new frmPlayfairInfo();
            playfairInfo.Show();
            if (txtMessage.Text != "" && getTableArray(getTableTextBoxes()) != null)
            {
                setMessageAndTable(txtMessage.Text, getTableArray(getTableTextBoxes()));
            }
            this.Close();
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Length > 0)
            {
                if (checkTableContent())
                {
                    char[] parsedMessage = parseText(txtMessage.Text.ToCharArray());
                    if (parsedMessage != null)
                    {
                        txtResult.Text = "";
                        if (rdoBtnEncrypt.Checked)
                        {
                            txtResult.Text = cipher(parsedMessage, "E");
                        }
                        else if (rdoBtnDecrypt.Checked)
                        {
                            txtResult.Text = cipher(parsedMessage, "D");
                        }
                        else
                        {
                            MessageBox.Show("Select if you want to encrypt or decrypt the text");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a message!");
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

        private void frmPlayfair_Load(object sender, EventArgs e)
        {
            rdoBtnEncrypt.Checked = true;
        }
    }
}
