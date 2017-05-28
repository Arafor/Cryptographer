using System;
using System.Windows.Forms;

namespace Cryptographer
{
    public partial class frmDiffieHellmanInfo : frmDiffieHellmanBase
    {
        public frmDiffieHellmanInfo()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
        }

        frmDiffieHellman DFCipher;

        private void btnDiffieHellman_Click(object sender, EventArgs e)
        {
            if (!DFCipher.Visible)
            {
                DFCipher = new frmDiffieHellman();
                DFCipher.Show();
                this.Close();
            }
        }

        private void frmDiffieHellmanInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDiffieHellmanInfo DFInfo = new frmDiffieHellmanInfo();
            DFInfo.Close();
        }

        private void frmDiffieHellmanInfo_Load(object sender, EventArgs e)
        {
            DFCipher = new frmDiffieHellman();
            updatePrimeNumberList();
        }
    }
}
