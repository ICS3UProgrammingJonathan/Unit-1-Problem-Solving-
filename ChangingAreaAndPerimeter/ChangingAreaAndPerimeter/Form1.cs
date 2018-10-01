/*
 * Created by: Jonathan Fok
 * Created on: 9-18-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Name of Program
 * This program can calulate the perimeter and area
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangingAreaAndPerimeter
{
    public partial class frmChangingAreaAndPerimeter : Form
    {
        public frmChangingAreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void frmChangingAreaAndPerimeter_Load(object sender, EventArgs e)
        {

        }

        private void lblPerimeter_Click(object sender, EventArgs e)
        {
            this.lblPerimeter.Hide();

        }

        private void lblArea_Click(object sender, EventArgs e)
        {
            this.lblArea.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //#Declare the variables
            double length, width, area, perimeter;

            //*Convert the string
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            //*Calculate the Area and Perimeter
            area = length * width;
            perimeter = 2 * width + 2 * length;

            //*insert the area and perimeter into the label
            this.lblAreaAnswer.Text = Convert.ToString(area) + "Squared Meters";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + "Squared Meters";

            //*Display the answers
            this.lblPerimeter.Show();
            this.lblArea.Show();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
