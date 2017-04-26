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
    public partial class frmDiffieHellmanBase : Form
    {
        ToolTip textboxToolTip = new ToolTip();

        public frmDiffieHellmanBase()
        {
            InitializeComponent();
            textboxToolTip.IsBalloon = true;
            textboxToolTip.AutoPopDelay = 1000;
            textboxToolTip.InitialDelay = 1000;
            textboxToolTip.ReshowDelay = 500;
        }

        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private void txtPrimeNumber_TextChanged(object sender, EventArgs e)
        {
            int parsedNumber;
            if (!int.TryParse(txtPrimeNumber.Text, out parsedNumber)) parsedNumber = 0;
            bool textIsPrime = isPrime(parsedNumber);
            if (textIsPrime)
            {
                textboxToolTip.Hide(txtPrimeNumber);
                txtPrimeNumber.ForeColor = Color.Black;
            }
            else
            {
                txtPrimeNumber.ForeColor = Color.Red;
                textboxToolTip.Show(string.Empty, txtPrimeNumber);
                textboxToolTip.Show("The entered value is not a prime number", txtPrimeNumber);
            }
        }
    }
}
