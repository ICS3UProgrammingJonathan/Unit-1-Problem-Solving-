/*
 * Created by: Jonathan Fok
 * Created on: 17-9-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Name of Program
 * This program...
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

namespace SchoolMascot
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void frmSchoolMascot_Load(object sender, EventArgs e)
        {

        }
        /* This is the code that make the program shows the name of Glebe when user click the menuitem */
        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            this.lblSchoolMascot.Text = "Immaculata";
        }

        private void lblSchoolMascotMenu_Click(object sender, EventArgs e)
        {

        }
        /* This is the code that make the program shows the name of Glebe when user click the menuitem */
        private void mniAshbury_Click(object sender, EventArgs e)
        {
            this.lblSchoolMascot.Text = "Ashbury";
        }
        /* This is the code that make the program shows the name of Glebe when user click the menuitem */
         
        private void mniGlebe_Click(object sender, EventArgs e)
        {
            this.lblSchoolMascot.Text = "Glebe";
        }
    }
}
