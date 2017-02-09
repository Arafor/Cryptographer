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
        char[] allowedLetters =
        {
                Convert.ToChar("A"),
                Convert.ToChar("B"),
                Convert.ToChar("C"),
                Convert.ToChar("D"),
                Convert.ToChar("E"),
                Convert.ToChar("F"),
                Convert.ToChar("G"),
                Convert.ToChar("H"),
                Convert.ToChar("I"),
                Convert.ToChar("J"),
                Convert.ToChar("K"),
                Convert.ToChar("L"),
                Convert.ToChar("M"),
                Convert.ToChar("N"),
                Convert.ToChar("O"),
                Convert.ToChar("P"),
                Convert.ToChar("Q"),
                Convert.ToChar("R"),
                Convert.ToChar("S"),
                Convert.ToChar("T"),
                Convert.ToChar("U"),
                Convert.ToChar("V"),
                Convert.ToChar("W"),
                Convert.ToChar("X"),
                Convert.ToChar("Y"),
                Convert.ToChar("Z")
        };

        char[] replaceableLetters =
        {
                Convert.ToChar(" "),
                Convert.ToChar(","),
                Convert.ToChar("."),
                Convert.ToChar("?"),
                Convert.ToChar("!"),
        };
        char[,] table = new char[5, 5]
        {
            { },
            { },
            { },
            { },
            { },

        };

        public char[] parseText(char[] message)
        {
            char[] parsedMessage;

            return parsedMessage;
        }

        public frmPlayfair()
        {
            InitializeComponent();
        }

        private void tblTable_TextChanged(object sender, EventArgs e)
        {
            //txtTable00.Text = txtTable00.Text.ToUpper();
            this.Text = this.Text.ToUpper();
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            char[] message = txtMessage.Text.ToCharArray();
            
        }
    }
}
