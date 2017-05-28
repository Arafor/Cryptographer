namespace Cryptographer
{
    public partial class frmDiffieHellman : frmDiffieHellmanBase
    {

        public frmDiffieHellman()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmCryptographer formCryptographer = new frmCryptographer();
            formWindowManager.setFormWindowLocation(formCryptographer, this);
        }

        frmDiffieHellmanInfo DFInfo;

        private void btnDiffieHellmanInfo_Click(object sender, System.EventArgs e)
        {
            if (!DFInfo.Visible)
            {
                DFInfo = new frmDiffieHellmanInfo();
                DFInfo.Show();
                this.Close();
            }
        }

        private void frmDiffieHellman_Load(object sender, System.EventArgs e)
        {
            DFInfo = new frmDiffieHellmanInfo();
            updatePrimeNumberList();
        }

        private void frmDiffieHellman_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            frmDiffieHellman DFCipher = new frmDiffieHellman();
            DFCipher.Close();
        }
    }
}
