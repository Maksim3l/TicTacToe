using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToe
{
    public partial class TitleScreen : Form
    {
        public static string P1N = "";
        public static string P2N = "";
        public TitleScreen()
        {
            InitializeComponent();
        }

        private void QuitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayB_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            QuitB.Visible = false;
            PlayB.Visible = false;

            label2.Visible = true;
            label3.Visible = true;
            Player1N.Visible = true;
            Player2NB.Visible = true;
            this.Refresh();
        }

        private void PlayB_Click_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            QuitB.Visible = false;
            PlayB.Visible = false;

            label2.Visible = true;
            label3.Visible = true;
            Player1N.Visible = true;
            Player2NB.Visible = true;
            StartB.Visible = true;
            this.Refresh();
        }

        private void QuitB_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Player1N_TextChanged(object sender, EventArgs e)
        {
            P1N = Player1N.Text;
        }

        private void Player2N_TextChanged(object sender, EventArgs e)
        {
            P2N = Player2NB.Text;
        }

        private void StartB_Click(object sender, EventArgs e)
        {
            Player1 P1 = new Player1();
            TitleScreen T = new TitleScreen();
            P1N = Player1N.Text;
            P2N = Player2NB.Text;
            P1.ShowDialog();
           
        }
    }
}
