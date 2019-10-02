/*
 * Created by: Tobi Adebyo
 * Created on: 26-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - PerAreaVolTobiAdebayo
 * This program performs basic mathematics operations
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

namespace WindowsFormsApp1
{
    public partial class frmCalculations : Form
    {
        public frmCalculations()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculations_Load(object sender, EventArgs e)
        {

        }

        private void btnEquations1_Click(object sender, EventArgs e)
        {
            this.lblAnswer1.Text = Convert.ToString(5 * 2 + 8 * 2) + " cm";
        }

        private void btnEquations2_Click(object sender, EventArgs e)
        {
            this.lblAnswer2.Text = Convert.ToString((7 * 7) * Math.PI) + " cm^2";
        }

        private void btnEquations3_Click(object sender, EventArgs e)
        {
            this.lblAnswer3.Text = Convert.ToString(((double)4 / (double)3) * Math.PI * (4 * 4 * 4)) + " cm^3";
        }
    }
}
