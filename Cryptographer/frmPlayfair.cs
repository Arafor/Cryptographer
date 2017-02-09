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
    public partial class frmPlayfair : Form
    {
        public frmPlayfair()
        {
            InitializeComponent();
        }

        private void tblTable_TextChanged(object sender, EventArgs e)
        {
            //txtTable00.Text = txtTable00.Text.ToUpper();
            this.Text = this.Text.ToUpper();
        }
    }
}
