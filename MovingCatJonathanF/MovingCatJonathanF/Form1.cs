/*
 * Created by: Jonathan Fok
 * Created on: 17-9-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Name of Program
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

namespace MovingCatJonathanF
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void cat1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMovingCat_Load(object sender, EventArgs e)
        {

        }
        /* This code makes the image change to cat1 when the user clickthe cat1 menu item*/
        private void mniCat1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;

        }
        /* This code makes the image change to cat2 when the user clickthe cat1 menu item*/
        private void mniCat2_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
        }
        /* This code create the exit menu item*/
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
