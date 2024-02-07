using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TickTackToe
{
    public partial class EndingScreen : Form
    {
        public static int victor;
        public EndingScreen()
        {
            InitializeComponent();
        }
        
        private void EndingScreen_Load(object sender, EventArgs e)
        {
            if (victor == 1) label3.Text = TitleScreen.P1N;
            else if (victor == 2) label3.Text = TitleScreen.P2N;
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
