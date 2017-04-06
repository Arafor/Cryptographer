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
            tblTable.Location = new Point(15, 300);
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            frmPlayfair playfair = new frmPlayfair();
            playfair.Show();
            if (txtMessage.Text != "" && getTableArray(getTableTextBoxes()) != null)
            {
                setMessageAndTable(txtMessage.Text, getTableArray(getTableTextBoxes()));
            }
            this.Close();
        }
    }
}
