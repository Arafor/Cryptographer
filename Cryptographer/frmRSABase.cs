using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Cryptographer
{
    public partial class frmRSABase : Form
    {
        public frmRSABase()
        {
            InitializeComponent();
        }

        NumericalAlphabet numAlphabet = new NumericalAlphabet();
        TextParser textParser = new TextParser();
        
        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }

        }

        static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                MessageBox.Show(e.ToString());

                return null;
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

        public void setMessageAndKey(string message, string key)
        {
            txtMessage.Text = message;
            txtKey.Text = key;
        }

        //Display values in binary or hexadecimal
        private void grpValueDisplayMode_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoBinary.Checked)
                {
                    string resultText = txtResult.Text;
                    txtResult.Text = "";
                    foreach (byte resultByte in textParser.parseHexadecimalStringToBytes(resultText))
                    {
                        txtResult.Text = txtResult.Text + Convert.ToString(resultByte, 2).PadLeft(8, '0');
                    }
                }
                else if (rdoHexadecimal.Checked)
                {
                    txtResult.Text = BitConverter.ToString(textParser.parseBinaryStringToBytes(txtResult.Text)).Replace("-", "");
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
