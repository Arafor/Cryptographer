﻿using System;
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
        public frmCryptographer()
        {
            InitializeComponent();
            FormWindowManager formWindowManager = new FormWindowManager();
            formWindowManager.setFormWindowSize(this);
            formWindowManager.setFormWindowLocation(null, this);
        }

        private void btnCaesar_Click(object sender, EventArgs e)
        {
            frmCaesar ceasarCipher = new frmCaesar();
            ceasarCipher.Show();
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            frmVigenere vigenereCipher = new frmVigenere();
            vigenereCipher.Show();
        }

        private void btnPlayfair_Click(object sender, EventArgs e)
        {
            frmPlayfair playfairCipher = new frmPlayfair();
            playfairCipher.Show();
        }

        private void btnDiffieHellman_Click(object sender, EventArgs e)
        {
            frmDiffieHellman diffieHellman = new frmDiffieHellman();
            diffieHellman.Show();
        }
    }
}
