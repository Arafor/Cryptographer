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
    public partial class frmCryptographer : Form
    {
        //List of forms to go to
        frmCaesar ceasarCipher;
        frmVigenere vigenereCipher;
        frmPlayfair playfairCipher;
        frmDiffieHellman diffieHellman;

        public frmCryptographer()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            formWindowManager.setFormWindowLocation(null, this);
        }

        private void btnCaesar_Click(object sender, EventArgs e)
        {
            //Check if form window is already open or not
            if (!ceasarCipher.Visible)
            {
                //Create new form window in case it is closed
                ceasarCipher = new frmCaesar();
                ceasarCipher.Show();
            }
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            if (!vigenereCipher.Visible)
            {
                vigenereCipher = new frmVigenere();
                vigenereCipher.Show();
            }
        }

        private void btnPlayfair_Click(object sender, EventArgs e)
        {
            if (!playfairCipher.Visible)
            {
                playfairCipher = new frmPlayfair();
                playfairCipher.Show();
            }
        }

        private void btnDiffieHellman_Click(object sender, EventArgs e)
        {
            if (!diffieHellman.Visible)
            {
                diffieHellman = new frmDiffieHellman();
                diffieHellman.Show();
            }
        }

        private void frmCryptographer_Load(object sender, EventArgs e)
        {
            ceasarCipher = new frmCaesar();
            vigenereCipher = new frmVigenere();
            playfairCipher = new frmPlayfair();
            diffieHellman = new frmDiffieHellman();
        }
    }
}
