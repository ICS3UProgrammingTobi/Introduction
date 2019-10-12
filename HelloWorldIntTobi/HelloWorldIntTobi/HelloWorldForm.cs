/*
 * Created by: Tobi adebayo
 * Created on: 11-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello world
 * This program Says hello world in different languages
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

namespace HelloWorldIntTobi
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void LblGreeting_Click(object sender, EventArgs e)
        {

        }
        //assign each button to its language
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hola Mundo!";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Ciao mondo!";
        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello World!";
        }

        private void RadFrench_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Bonjour le monde!";
        }
    }
}
