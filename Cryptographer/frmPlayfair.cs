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
    }
}
