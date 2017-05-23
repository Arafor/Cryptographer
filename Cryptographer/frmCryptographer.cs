using System;
using System.Windows.Forms;

namespace Cryptographer
{
    public partial class frmCryptographer : Form
    {
        //List of forms to go to
        frmCaesar ceasarCipher;
        frmVigenere vigenereCipher;
        frmPlayfair playfairCipher;
        frmDES DESCipher;
        frmAES AESCipher;
        frmRSA RSACipher;
        frmRSASignature RSASigature;
        frmDiffieHellman diffieHellman;

        public frmCryptographer()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            formWindowManager.setFormWindowLocation(null, this);
        }

        private void frmCryptographer_Load(object sender, EventArgs e)
        {
            ceasarCipher = new frmCaesar();
            vigenereCipher = new frmVigenere();
            playfairCipher = new frmPlayfair();
            DESCipher = new frmDES();
            AESCipher = new frmAES();
            RSACipher = new frmRSA();
            RSASigature = new frmRSASignature();
            diffieHellman = new frmDiffieHellman();
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

        private void btnDES_Click(object sender, EventArgs e)
        {
            if (!DESCipher.Visible)
            {
                DESCipher = new frmDES();
                DESCipher.Show();
            }
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            if (!AESCipher.Visible)
            {
                AESCipher = new frmAES();
                AESCipher.Show();
            }
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            if (!RSACipher.Visible)
            {
                RSACipher = new frmRSA();
                RSACipher.Show();
            }
        }

        private void btnRSASignature_Click(object sender, EventArgs e)
        {
            if (!RSASigature.Visible)
            {
                RSASigature = new frmRSASignature();
                RSASigature.Show();
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
    }
}
