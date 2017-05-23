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
    }
}
