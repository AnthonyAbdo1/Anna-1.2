using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anna
{
    public partial class WriteToFileForm : Form
    {
        public WriteToFileForm()
        {
            InitializeComponent();
        }

        private void FilePathLocationTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WriteToFileBtn_Click(object sender, EventArgs e)
        {
            var fileName = FilePathLocationTxtBox.Text;

            var lines = FileInputBox.Text;

            // Set a variable to the Documents path.
            string path = @"C:\ProgramLogs\";


            // Write the string array to a new file named "WriteLines.txt".
            if (!File.Exists(path + fileName + ".txt"))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path + fileName + ".txt"))
                {
                    sw.WriteLine(FileInputBox.Text);

                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path + fileName + ".txt"))
            {
                sw.WriteLine(FileInputBox.Text);

            }
        }

        private void ReadFromFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var fileName = FilePathLocationTxtBox.Text;

                string path = @"C:\ProgramLogs\";

                FileInputBox.Text = File.ReadAllText(path + fileName + ".txt");

            }

            catch (FileNotFoundException)
            {

            }
        }
    }
}
