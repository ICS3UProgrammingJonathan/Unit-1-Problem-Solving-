/*
 * Created by: Jonathan Fok
 * Created on: 25-9-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Circumference
 * This program can calulate the circumference of the circle by typing in the radius into the textbox.
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

namespace CircumJonathanF
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();

            // hide the circumference lable//
            this.lblStateCircumference.Hide();
            this.lblAnswer.Hide();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declare the variable//
            double radius, circumference;

            //Convert the string//

            radius = double.Parse(txtRadius.Text);

            //Calculate the area//

            circumference = 2 * Math.PI * radius;

            //Insert the circumference with the lable//

            this.lblAnswer.Text = Convert.ToString(circumference) + "cm";

            //Show the answer//

            this.lblAnswer.Show();
            this.lblStateCircumference.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
