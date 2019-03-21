using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anna
{
    public partial class ReadServerNotes : Form
    {
        public ReadServerNotes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NoteTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadNoteBtn_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=ACTIV-806;Initial Catalog=AnthonysSciencifier;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            try
            {
                string Query = "SELECT * FROM dbo.DataLog WHERE NoteSubject = '" + NoteTitle.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                SqlConnection MyConn2 = new SqlConnection(connectionString);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    NoteBody.Text = (MyReader2["NoteBody"].ToString());
                }
              
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            cnn.Close();
        }

            private void NoteBody_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
