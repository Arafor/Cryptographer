using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptographer
{
    class Notes
    {
        /* Tooltip box ----------------------------------------------------------- */
        //Global
        //ToolTip textboxToolTip = new ToolTip();

        //On load
        /*textboxToolTip.IsBalloon = true;
        textboxToolTip.AutoPopDelay = 1000;
        textboxToolTip.InitialDelay = 1000;
        textboxToolTip.ReshowDelay = 500;*/

        //In code
        //textboxToolTip.Hide(txtPrimeNumber);
        //textboxToolTip.Show(string.Empty, txtPrimeNumber);
        //textboxToolTip.Show("The entered value is not a prime number", txtPrimeNumber);

        //protected void btnExport_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("The information that the table contains must remain secret!\nYour encrypted messages can be easilly decrypted if someone has your table.");
        //    // Fill table with imported letters
        //    TextBox[] tableTextBoxes = getTableTextBoxes();
        //    string letters = "";
        //    foreach (TextBox txtBox in tableTextBoxes)
        //    {
        //        letters = letters + txtBox.Text;
        //    }

        //    fileManager.exportFile(letters);
        //}

        //protected void btnImport_Click(object sender, EventArgs e)
        //{
        //    // Get file content
        //    string file = fileManager.importFile();
        //    string fileContent = fileManager.getFileContent(file);
        //    int fileContentLength = fileContent.Length;

        //    // The file must contain exactly 25 letters for the table
        //    if (fileContent.Length == 25)
        //    {
        //        // Make sure the imported text contains all of the necessary letters
        //        char[] fileContentCharArray = fileContent.ToCharArray();
        //        int j = 0;
        //        bool containedLettersAreOk = true;
        //        foreach (char letter in numAlphabet.getAlphabet())
        //        {
        //            // Skip letter "J" since the table can not contain it
        //            if (letter == Convert.ToChar("J")) continue;
        //            for (j = 0; j < fileContentCharArray.Length; j++)
        //            {
        //                if (fileContentCharArray[j] == letter)
        //                {
        //                    break;
        //                }
        //            }

        //            if (j >= 25)
        //            {
        //                MessageBox.Show("The chosen file does not contain all of the necessary letters!");
        //                containedLettersAreOk = false;
        //                break;
        //            }
        //        }

        //        if (containedLettersAreOk)
        //        {
        //            // Fill table with imported letters
        //            TextBox[] tableTextBoxes = getTableTextBoxes();
        //            int i = 0;
        //            foreach (TextBox txtBox in tableTextBoxes)
        //            {
        //                txtBox.Text = fileContentCharArray[i].ToString();
        //                i++;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("The chosen file does not contain 25 characters.\nPlease choose a different file.");
        //    }

        //}
    }
}
