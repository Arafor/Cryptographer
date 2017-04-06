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
            txtMessage.Location = new Point(0, 0);
        }

        private void btnVigenereInfo_Click(object sender, EventArgs e)
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
