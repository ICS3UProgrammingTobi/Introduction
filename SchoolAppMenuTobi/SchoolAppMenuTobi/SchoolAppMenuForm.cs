/*
 * Created by: Tobi Adebayo
 * Created on: September 9, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - Hello World with Menu
 * This program displays Hello World but with an exit menu
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

namespace SchoolAppMenuTobi
{
    public partial class frmSchoolAppMenu : Form
    {
        public frmSchoolAppMenu()
        {
            InitializeComponent();
        }

        private void FrmSchoolAppMenu_Load(object sender, EventArgs e)
        {

        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // This Exits the program
            this.Close();
        }
    }
}
