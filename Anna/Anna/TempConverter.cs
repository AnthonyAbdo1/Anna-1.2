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

    public partial class TempConverter : Form
    {
        public TempConverter()
        {
            InitializeComponent();
        }

        private void FahrenheitBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FtoCbtn_Click(object sender, EventArgs e)
        {
            try {
                if (FtoC.Checked == true)
                {
                    var convert = new FtoC_Converter();
                    FahrenheitBox.Text = FahrenheitBox.Text + " Degrees Fahrenheit Is " + convert.FtoC_Con(FahrenheitBox.Text) + " Celsius";
                }

                else if (CtoF.Checked == true)
                {
                    var convert = new CtoF_Converter();
                    FahrenheitBox.Text = FahrenheitBox.Text + " Degrees Celsius Is " + convert.CtoF_Con(FahrenheitBox.Text) + " Fahrenheit";
                }

                else if (CtoK.Checked == true)
                {
                    var convert = new CtoK_Converter();
                    FahrenheitBox.Text = FahrenheitBox.Text + " Degrees Celsius Is " + convert.CtoK_Con(FahrenheitBox.Text) + " Kelvin";
                }

                else
                {
                    MessageBox.Show("Please select a conversion formula");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please make sure only one formula box is selected before converting or that you have a valid entry in the input field");
            }
        }

        private void FtoC_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CtoF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CtoK_CheckedChanged(object sender, EventArgs e)
        {

        }
    }


    public class FtoC_Converter
    {
        public string FtoC_Con(string temp)
        {
            double celsius;
            double temperature = Convert.ToDouble(temp);
            celsius = (temperature - 32) * 5 / 9;
            return (celsius).ToString();
        }
    }

    public class CtoF_Converter
    {
        public string CtoF_Con(string temp)
        {
            double fahrenhiet;
            double tempurature = Convert.ToDouble(temp);
            fahrenhiet = (tempurature * 5 / 9) + 32;
            return (fahrenhiet).ToString();
        }
    }

    public class CtoK_Converter
    {
        public string CtoK_Con(string temp)
        {
            double kelvin;
            double tempurature = Convert.ToDouble(temp);
            kelvin = (tempurature + 273.15);
            return (kelvin).ToString();
        }
    }

}
