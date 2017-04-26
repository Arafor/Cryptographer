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
    public partial class frmDiffieHellmanBase : Form
    {
        

        public frmDiffieHellmanBase()
        {
            InitializeComponent();
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
            //Check if number is prime
            int parsedNumber;
            if (!int.TryParse(txtPrimeNumber.Text, out parsedNumber)) parsedNumber = 0;
            bool textIsPrime = isPrime(parsedNumber);
            if (textIsPrime)
            {
                txtPrimeNumber.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
            else
            {
                txtPrimeNumber.ForeColor = Color.Red;
                errorProvider1.SetError(txtPrimeNumber, "The entered value is not a prime number");
            }
        }
    }
}
