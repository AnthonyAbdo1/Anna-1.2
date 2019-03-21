using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anna
{
    public partial class NavigationMenu : Form
    {
        public NavigationMenu()
        {
            InitializeComponent();
        
        }

        private void NavigationMenu_Load(object sender, EventArgs e)
        {

        }

        private void LogToFile_Click(object sender, EventArgs e)
        {
            WriteToFileForm writetofile = new WriteToFileForm();
            writetofile.Show();
        }

        private void LogToServerBtn_Click(object sender, EventArgs e)
        {
            LogToServer logServer = new LogToServer();
            logServer.Show();
        }

        private void SearchServerNotes_Click(object sender, EventArgs e)
        {
            ReadServerNotes readServer = new ReadServerNotes();
            readServer.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TempConverter tempConverter = new TempConverter();
            tempConverter.Show();
        }

        private void Weight_Click(object sender, EventArgs e)
        {
            WeightConverter weightConverter = new WeightConverter();
            weightConverter.Show();
        }
    }
}
