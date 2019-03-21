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
    public partial class WeightConverter : Form
    {
        public WeightConverter()
        {
            InitializeComponent();
        }

        private void WeightConverter_Load(object sender, EventArgs e)
        {

        }

        private void LiquedConverterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(OunceToGill.Checked == true)
                {
                    var convert = new OunceToGillConverter();
                    LiquedCoverterTxtBox.Text = LiquedCoverterTxtBox.Text + " Ounces Is " + convert.OtoC_Converter(LiquedCoverterTxtBox.Text) + " Gills";

                }
                else if (GillToPint.Checked == true)
                {
                    var convert = new GillToPintConverter();
                    LiquedCoverterTxtBox.Text = LiquedCoverterTxtBox.Text + " Gills Is " + convert.GtoP_Coverter(LiquedCoverterTxtBox.Text) + " Pints";

                }
                else if (PintToQuart.Checked == true)
                {
                    var convert = new PintToQuartConverter();
                    LiquedCoverterTxtBox.Text = LiquedCoverterTxtBox.Text + " Pints Is " + convert.PtoC_Converter(LiquedCoverterTxtBox.Text) + " Quarts";

                }
                else if (QuartToGallon.Checked == true)
                {
                    var convert = new QuartToGallonConverter();
                    LiquedCoverterTxtBox.Text = LiquedCoverterTxtBox.Text + " Quarts Is " + convert.QtoG_Converter(LiquedCoverterTxtBox.Text) + " Gallons";

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

        private void LiquedCoverterTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OunceToGill_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GillToPint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PintToQuart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QuartToGallon_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public class OunceToGillConverter {

    public string OtoC_Converter(string unit){
            double Gill;
            double Weight = Convert.ToDouble(unit);
            Gill = Weight / 4;
            return (Gill).ToString();
        }
           
    }
    public class GillToPintConverter {

    public string GtoP_Coverter(string unit){
            double Pint;
            double Weight = Convert.ToDouble(unit);
            Pint = Weight / 4;
            return (Pint).ToString();
        }

    }
    public class PintToQuartConverter {

    public string PtoC_Converter (string unit){
            double Quart;
            double Weight = Convert.ToDouble(unit);
            Quart = Weight / 2.402;
            return (Quart).ToString();
        }

    }
    public class QuartToGallonConverter {

    public string QtoG_Converter(string unit){
            double Gallon;
            double Weight = Convert.ToDouble(unit);
            Gallon = Weight / 3.331;
            return (Gallon).ToString();
        }

    }

}
