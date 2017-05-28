using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Numerics;

namespace Cryptographer
{
    public partial class frmDiffieHellmanBase : Form
    {
        IDictionary<int, int> primitiveRootsOfPrimeNumbers = new Dictionary<int, int>();

        public frmDiffieHellmanBase()
        {
            InitializeComponent();
            this.ActiveControl = cmbPrimeNumber;
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

        private void cmbPrimeNumber_ValueChanged(object sender, EventArgs e)
        {
            updatePrimitiveRootTextBox();
        }

        protected void updatePrimitiveRootTextBox()
        {
            txtPrimitiveRoot.Text = "";
            //Check if the entered value is a natural number
            if (assertNaturalNumber(cmbPrimeNumber))
            {
                int parsedNumber;
                if (!int.TryParse(cmbPrimeNumber.Text, out parsedNumber)) parsedNumber = 0;
                //Check if the number isnt higher than what we have primitive roots for
                if (parsedNumber <= 97)
                {
                    //Check if the entered value is a prime number
                    if (isPrime(parsedNumber))
                    {
                        //Check if this prime number has a primitive root
                        try
                        {
                            txtPrimitiveRoot.Text = primitiveRootsOfPrimeNumbers[parsedNumber].ToString();
                        }
                        catch (KeyNotFoundException)
                        {
                            cmbPrimeNumber.ForeColor = Color.Red;
                            errorProvider1.SetError(cmbPrimeNumber, "This prime number does not have a primitive root; Please choose a different number");
                        }
                    }
                    else
                    {
                        cmbPrimeNumber.ForeColor = Color.Red;
                        errorProvider1.SetError(cmbPrimeNumber, "The entered value is not a prime number");
                    }
                }
                else
                {
                    cmbPrimeNumber.ForeColor = Color.Red;
                    errorProvider1.SetError(cmbPrimeNumber, "The highest allowed prime number is 97; Please choose a different number");
                }
            }
        }

        private void txtPrimitiveRoot_TextChanged(object sender, EventArgs e)
        {
            updateSecretTextBox();
        }

        private void txtSecretNumber_TextChanged(object sender, EventArgs e)
        {
            updateSecretTextBox();
        }

        protected void updateSecretTextBox()
        {
            txtSecret.Text = "";
            //Check if the entered value is a natural number
            if (assertNaturalNumber(txtSecretNumber))
            {
                int parsedNumber;
                if (!int.TryParse(txtSecretNumber.Text, out parsedNumber)) parsedNumber = 0;
                //Check if primitive root is not empty
                if (txtPrimitiveRoot.Text != "")
                {
                    txtSecret.Text = BigInteger.ModPow(int.Parse(txtPrimitiveRoot.Text), parsedNumber, int.Parse(cmbPrimeNumber.Text)).ToString();
                }
                else
                {
                    cmbPrimeNumber.ForeColor = Color.Red;
                    errorProvider1.SetError(cmbPrimeNumber, "You need a prime number and a primitive root to create your secret");
                }
            }
        }

        protected void setErrorMessage(TextBox target, string message)
        {
            target.ForeColor = Color.Red;
            errorProvider1.SetError(target, message);
        }

        protected void setErrorMessage(ComboBox target, string message)
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
                catch (OverflowException)
                {
                    setErrorMessage(target, "The chosen value is too large");

                    return false;
                }
                catch (Exception)
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

        protected bool assertNaturalNumber(ComboBox target)
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
                catch (OverflowException)
                {
                    setErrorMessage(target, "The chosen value is too large");

                    return false;
                }
                catch (Exception)
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

        private void txtOtherSecret_TextChanged(object sender, EventArgs e)
        {
            updateSharedSecretTextBox();
        }

        protected void updateSharedSecretTextBox()
        {
            txtSharedSecret.Text = "";
            //Check if the entered value is a natural number
            if (assertNaturalNumber(txtOtherSecret))
            {
                int parsedNumber;
                if (!int.TryParse(txtOtherSecret.Text, out parsedNumber)) parsedNumber = 0;
                //Check if we have a secret to work with
                if (txtSecret.Text != "")
                {
                    txtSharedSecret.Text = BigInteger.ModPow(parsedNumber, int.Parse(txtSecretNumber.Text), int.Parse(cmbPrimeNumber.Text)).ToString();
                }
                else
                {
                    txtSecretNumber.ForeColor = Color.Red;
                    errorProvider1.SetError(txtSecretNumber, "To get the shared secret you need to create your own secret as well");
                }
            }
        }

        private void txtSecret_TextChanged(object sender, EventArgs e)
        {
            updateSharedSecretTextBox();
        }

        protected void updatePrimeNumberList()
        {
            foreach(int prime in primitiveRootsOfPrimeNumbers.Keys)
            {
                cmbPrimeNumber.Items.Add(prime);
            }
        }
    }
}
