using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptographer
{
    class FileManager
    {
        public void exportFile(string fileContent)
        {
            // Prepare SaveFileDialog for file saving 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "*.txt";
            saveFileDialog1.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save text to file";

            // If the file name is not an empty then save to file  
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                // Check if we need to create a new file
                if (!System.IO.File.Exists(saveFileDialog1.InitialDirectory + saveFileDialog1.FileName))
                {
                    FileStream fs = System.IO.File.Create(saveFileDialog1.InitialDirectory + saveFileDialog1.FileName);
                    fs.Close();
                }
                // Write to file
                File.WriteAllText(saveFileDialog1.InitialDirectory + saveFileDialog1.FileName, fileContent);
            }
        }

        public string importFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Prepare and open the dialog window
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string importedFile = openFileDialog1.FileName;

                return importedFile;
            }
            // For debuging
            Console.WriteLine(result);

            return null;
        }

        public string getFileContent(string file)
        {
            // Get the text from the chosen file
            string fileContent = "";
            try
            {
                fileContent = File.ReadAllText(file);
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.ToString());
            }

            return fileContent;
        }
    }
}
