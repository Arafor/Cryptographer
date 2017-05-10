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
        IDictionary<int, int> primitiveRootsOfPrimeNumbers = new Dictionary<int, int>();

        public frmDiffieHellmanBase()
        {
            InitializeComponent();
            this.ActiveControl = txtPrimeNumber;
            generatePrimitiveRootNumbersOfPrimeNumbers();
        }

        public void generatePrimitiveRootNumbersOfPrimeNumbers()
        {
            primitiveRootsOfPrimeNumbers[3] = 2;
            primitiveRootsOfPrimeNumbers[5] = 2;
            primitiveRootsOfPrimeNumbers[7] = 3;
            primitiveRootsOfPrimeNumbers[11] = 2;
            primitiveRootsOfPrimeNumbers[13] = 6;
            primitiveRootsOfPrimeNumbers[17] = 10;
            primitiveRootsOfPrimeNumbers[19] = 10;
            primitiveRootsOfPrimeNumbers[23] = 10;
            primitiveRootsOfPrimeNumbers[29] = 10;
            primitiveRootsOfPrimeNumbers[31] = 17;
            primitiveRootsOfPrimeNumbers[37] = 5;
            primitiveRootsOfPrimeNumbers[41] = 6;
            primitiveRootsOfPrimeNumbers[43] = 28;
            primitiveRootsOfPrimeNumbers[47] = 10;
            primitiveRootsOfPrimeNumbers[53] = 26;
            primitiveRootsOfPrimeNumbers[59] = 10;
            primitiveRootsOfPrimeNumbers[61] = 12;
            primitiveRootsOfPrimeNumbers[67] = 12;
            primitiveRootsOfPrimeNumbers[71] = 62;
            primitiveRootsOfPrimeNumbers[73] = 5;
            primitiveRootsOfPrimeNumbers[79] = 29;
            primitiveRootsOfPrimeNumbers[83] = 50;
            primitiveRootsOfPrimeNumbers[89] = 30;
            primitiveRootsOfPrimeNumbers[97] = 10;
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
            txtPrimitiveRoot.Text = "";
            //Clear previous errors
            txtPrimeNumber.ForeColor = Color.Black;
            errorProvider1.Clear();

            //Check if the field is not empty
            if (txtPrimeNumber.Text != "")
            {
                //Check if the entered value is an integer
                try
                {
                    int.Parse(txtPrimeNumber.Text);
                }
                catch (Exception exc)
                {
                    txtPrimeNumber.ForeColor = Color.Red;
                    errorProvider1.SetError(txtPrimeNumber, "The value must be a natural number");
                    return;
                    //MessageBox.Show("The value must be a natural number");
                }

                //Check if the entered value is a natural number
                int parsedNumber;
                if (!int.TryParse(txtPrimeNumber.Text, out parsedNumber)) parsedNumber = 0;
                if (parsedNumber > 0)
                {
                    //Check if the number isnt higher than what we have primitive roots for
                    if (parsedNumber <= 97)
                    {
                        //Check if the entered value is a prime number
                        //bool textIsPrime = isPrime(parsedNumber);
                        if (isPrime(parsedNumber))
                        {
                            //Check if this prime number has a primitive root
                            try //(primitiveRootsOfPrimeNumbers[parsedNumber] == null
                            {
                                //txtPrimeNumber.ForeColor = Color.Black;
                                //errorProvider1.Clear();
                                txtPrimitiveRoot.Text = primitiveRootsOfPrimeNumbers[parsedNumber].ToString();
                            }
                            catch (KeyNotFoundException exc)
                            {
                                txtPrimeNumber.ForeColor = Color.Red;
                                errorProvider1.SetError(txtPrimeNumber, "This prime number does not have a primitive root; Please choose a different number");
                            }
                        }
                        else
                        {
                            txtPrimeNumber.ForeColor = Color.Red;
                            errorProvider1.SetError(txtPrimeNumber, "The entered value is not a prime number");
                        }
                    }
                    else
                    {
                        txtPrimeNumber.ForeColor = Color.Red;
                        errorProvider1.SetError(txtPrimeNumber, "The highest allowed prime number is 97; Please choose a different number");
                    }
                }
                else
                {
                    txtPrimeNumber.ForeColor = Color.Red;
                    errorProvider1.SetError(txtPrimeNumber, "A prime number can only be a natural number (0 <)");
                }
            }
        }

        private void txtPrimitiveRoot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecretNumber_TextChanged(object sender, EventArgs e)
        {
            txtSecret.Text = "";
            //Clear previous errors
            txtSecretNumber.ForeColor = Color.Black;
            errorProvider1.Clear();

            //Check if the field is not empty
            if (txtSecretNumber.Text != "")
            {
                //Check if the entered value is an integer
                try
                {
                    int.Parse(txtSecretNumber.Text);
                }
                catch (Exception exc)
                {
                    txtSecretNumber.ForeColor = Color.Red;
                    errorProvider1.SetError(txtSecretNumber, "The value must be a natural number");
                    return;
                }

                //Check if the entered value is a natural number
                int parsedNumber;
                if (!int.TryParse(txtSecretNumber.Text, out parsedNumber)) parsedNumber = 0;
                if (parsedNumber > 0)
                {
                    if (txtPrimitiveRoot.Text != "")
                    {

                        txtSecret.Text = ((int.Parse(txtPrimitiveRoot.Text) ^ parsedNumber) % int.Parse(txtPrimeNumber.Text)).ToString();
                    } else
                    {
                        txtPrimeNumber.ForeColor = Color.Red;
                        errorProvider1.SetError(txtPrimeNumber, "You need a prime number and a primitive root to create your secret");
                    }
                }
                else
                {
                    //txtSecretNumber.ForeColor = Color.Red;
                    //errorProvider1.SetError(txtSecretNumber, "You must choose a natural number (0 <)");
                    setErrorMessage(txtSecretNumber, "You must choose a natural number (0 <)");
                }
            }
        }

        protected void setErrorMessage(TextBox target, string message)
        {
            target.ForeColor = Color.Red;
            errorProvider1.SetError(target, message);
        }

        protected bool assertNaturalNumber(TextBox target)
        {
            int enteredValue = 0;
            //Clear previous errors
            target.ForeColor = Color.Black;
            errorProvider1.Clear();
            //Check if the field is not empty
            if (target.Text != "")
            {
                //Check if the entered value is an integer
                try
                {
                    enteredValue = int.Parse(target.Text);
                }
                catch (Exception exc)
                {
                    setErrorMessage(target, "The value must be a natural number");
                    
                    return false;
                }

                //Check if the entered value is a natural number
                if (enteredValue > 0)
                {
                    return true;
                }
                else
                {
                    setErrorMessage(target, "A prime number can only be a natural number (0 <)");

                    return false;
                }
            }

            return false;
        }
    }
}
