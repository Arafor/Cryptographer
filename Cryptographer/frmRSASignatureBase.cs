using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Cryptographer
{
    public partial class frmRSASignatureBase : Form
    {
        public frmRSASignatureBase()
        {
            InitializeComponent();
        }

        NumericalAlphabet numAlphabet = new NumericalAlphabet();
        TextParser textParser = new TextParser();

        public static byte[] HashAndSignBytes(byte[] DataToSign, RSAParameters Key)
        {
            try
            {
                // Create a new instance of RSACryptoServiceProvider using the 
                // key from RSAParameters.  
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();

                RSAalg.ImportParameters(Key);

                // Hash and sign the data. Pass a new instance of SHA1CryptoServiceProvider
                // to specify the use of SHA1 for hashing.
                return RSAalg.SignData(DataToSign, new SHA1CryptoServiceProvider());
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);

                return null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

                return null;
            }
        }

        public static bool VerifySignedHash(byte[] DataToVerify, byte[] SignedData, RSAParameters Key)
        {
            try
            {
                // Create a new instance of RSACryptoServiceProvider using the 
                // key from RSAParameters.
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();

                RSAalg.ImportParameters(Key);

                // Verify the data using the signature.  Pass a new instance of SHA1CryptoServiceProvider
                // to specify the use of SHA1 for hashing.
                return RSAalg.VerifyData(DataToVerify, new SHA1CryptoServiceProvider(), SignedData);

            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);

                return false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

                return false;
            }
        }

        public Boolean checkEmptyFields(string txtBoxMessage)
        {
            // Check if there is a message to encrypt
            if (txtBoxMessage.Length > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a message");

                return false;
            }
        }

        public void setMessageAndKey(string data, string key, string signature)
        {
            txtSignedData.Text = data;
            txtKey.Text = key;
            txtSignature.Text = signature;
        }

        //Display values in binary or hexadecimal
        private void grpValueDisplayMode_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoBinary.Checked)
                {
                    string resultText = txtSignature.Text;
                    txtSignature.Text = "";
                    foreach (byte resultByte in textParser.parseHexadecimalStringToBytes(resultText))
                    {
                        txtSignature.Text = txtSignature.Text + Convert.ToString(resultByte, 2).PadLeft(8, '0');
                    }
                }
                else if (rdoHexadecimal.Checked)
                {
                    txtSignature.Text = BitConverter.ToString(textParser.parseBinaryStringToBytes(txtSignature.Text)).Replace("-", "");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

                return;
            }
        }

    }
}
