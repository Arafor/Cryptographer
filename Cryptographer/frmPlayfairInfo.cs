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
    public partial class frmPlayfairInfo : frmPlayfair
    {
        public frmPlayfairInfo()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            frmPlayfair formPlayfair = new frmPlayfair();
            formWindowManager.setFormWindowLocation(formPlayfair, this);
        }

        public void setMessageAndTable(string message, char[,] tableArray)
        {
            txtMessage.Text = message;
            fillUITable(getTableTextBoxes(), tableArray);
        }
    }
}
