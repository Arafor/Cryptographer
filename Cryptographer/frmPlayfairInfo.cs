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
    public partial class frmPlayfairInfo : frmPlayfairBase
    {
        public frmPlayfairInfo()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
            tblTable.Location = new Point(15, 250);
            this.ActiveControl = txtMessage;
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            frmPlayfair playfair = new frmPlayfair();
            playfair.Show();
            if (txtMessage.Text != "" && getTableArray(getTableTextBoxes()) != null)
            {
                playfair.setMessageAndTable(txtMessage.Text, getTableArray(getTableTextBoxes()));
            }
            this.Close();
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

        private void btnCipher_Click(object sender, EventArgs e)
        {
            txtMessageParsed.Text = "";
            txtMessageParsedPairs.Text = "";
            txtResult.Text = "";
            if (txtMessage.Text.Length > 0)
            {
                if (checkTableContent())
                {
                    try
                    {
                        var parsedMessage = new List<char>();
                        parsedMessage.AddRange(parseText(txtMessage.Text.ToCharArray()));
                        if (parsedMessage != null)
                        {
                            string cipherMessage = "";
                            if (rdoBtnEncrypt.Checked)
                            {
                                cipherMessage = cipher(parsedMessage.ToArray<char>(), "E");
                            }
                            else if (rdoBtnDecrypt.Checked)
                            {
                                cipherMessage = cipher(parsedMessage.ToArray<char>(), "D");
                            }
                            else
                            {
                                MessageBox.Show("Select if you want to encrypt or decrypt the text");
                            }
                            if (cipherMessage != "")
                            {
                                //Display parsed text
                                txtMessageParsed.Text = String.Join(String.Empty, parsedMessage).ToUpper();

                                //Display parsed text in pairs
                                txtMessageParsedPairs.Text = "";
                                int i = 0;
                                foreach (char letter in parsedMessage)
                                {
                                    if (i == 2)
                                    {
                                        txtMessageParsedPairs.Text = txtMessageParsedPairs.Text + " ";
                                        i = 0;
                                    }
                                    txtMessageParsedPairs.Text = txtMessageParsedPairs.Text + letter;
                                    i++;
                                }

                                //Display parsed text pairs togeather with the resulting messages pairs
                                string parsedMessagePairString = "";
                                string cipherMessagePairString = "";
                                lstPairs.Items.Clear();
                                for (int j = 0; j < cipherMessage.Length; j++)
                                {
                                    if (parsedMessagePairString.Length < 2 && cipherMessagePairString.Length < 2)
                                    {
                                        parsedMessagePairString = parsedMessagePairString + parsedMessage[j];
                                        cipherMessagePairString = cipherMessagePairString + cipherMessage[j];
                                    }
                                    if (parsedMessagePairString.Length == 2 && cipherMessagePairString.Length == 2)
                                    {
                                        lstPairs.Items.Add(parsedMessagePairString + " => " + cipherMessagePairString);
                                        parsedMessagePairString = "";
                                        cipherMessagePairString = "";
                                    }
                                }

                                //Display resulting message
                                txtResult.Text = cipherMessage;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a message.");
            }
        }

        private void frmPlayfairInfo_Load(object sender, EventArgs e)
        {
            rdoBtnEncrypt.Checked = true;
        }
    }
}
