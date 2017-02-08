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
    public partial class frmCaezar : Form
    {
        public frmCaezar()
        {
            InitializeComponent();
        }

        /*public encrypt(string plaintext, int key)
        {
            string ciphertext;
            return ciphertext;
        }*/

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //encrypt(txtPlaintext.Text, int.Parse(txtKey.Text));
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //encrypt(txtCiphertext.Text, int.Parse(txtKey.Text) * -1);
        }
    }
}
