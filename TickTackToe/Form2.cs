using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TickTackToe
{
    public partial class Player2 : Form
    {
        
        public Player2()
        {
            InitializeComponent();
        }

        private void B1P1_Click(object sender, EventArgs e)

        {

            if (B1P == 0) B1P = 1;
            if (B1P == 2) B1P1.Text = "O";
            if (B2P == 2) B2P1.Text = "O";
            if (B3P == 2) B3P1.Text = "O";
            if (B4P == 2) B4P1.Text = "O";
            if (B5P == 2) B5P1.Text = "O";
            if (B6P == 2) B6P1.Text = "O";
            if (B7P == 2) B7P1.Text = "O";
            if (B8P == 2) B8P1.Text = "O";
            if (B9P == 2) B9P1.Text = "O";
            if (B1P == 1) B1P1.Text = "X";
            if (B2P == 1) B2P1.Text = "X";
            if (B3P == 1) B3P1.Text = "X";
            if (B4P == 1) B4P1.Text = "X";
            if (B5P == 1) B5P1.Text = "X";
            if (B6P == 1) B6P1.Text = "X";
            if (B7P == 1) B7P1.Text = "X";
            if (B8P == 1) B8P1.Text = "X";
            if (B9P == 1) B9P1.Text = "X";
            Player1 P1 = new Player1();
            P1.Show();
            if (B1P == 2 && B2P == 2 && B3P == 2 ||
                B1P == 2 && B4P == 2 && B7P == 2 ||
                B1P == 2 && B5P == 2 && B9P == 2 ||
                B2P == 2 && B5P == 2 && B8P == 2 ||
                B3P == 2 && B6P == 2 && B9P == 2 ||
                B4P == 2 && B5P == 2 && B6P == 2 ||
                B7P == 2 && B8P == 2 && B9P == 2)
            {
                EndingScreen.victor = 2; EndingScreen E = new EndingScreen(); E.Show();
            }

        }

        private void displayNP1_Click(object sender, EventArgs e)
        {

        }

        private void displayNP2_Click(object sender, EventArgs e)
        {

        }

        private void Player2_Load(object sender, EventArgs e)
        {
            displayNP1.Text = TitleScreen.P1N;
            displayNP2.Text = TitleScreen.P2N;
            /*rules:*/
            
            B1P = Player1.B1P;
            B2P = Player1.B2P;
            B3P = Player1.B3P;
            B4P = Player1.B4P;
            B5P = Player1.B5P;
            B6P = Player1.B6P;
            B7P = Player1.B7P;
            B8P = Player1.B8P;
            B9P = Player1.B9P;

            if (B1P == 2) B1P1.Text = "O";
            if (B2P == 2) B2P1.Text = "O";
            if (B3P == 2) B3P1.Text = "O";
            if (B4P == 2) B4P1.Text = "O";
            if (B5P == 2) B5P1.Text = "O";
            if (B6P == 2) B6P1.Text = "O";
            if (B7P == 2) B7P1.Text = "O";
            if (B8P == 2) B8P1.Text = "O";
            if (B9P == 2) B9P1.Text = "O";
            if (B1P == 1) B1P1.Text = "X";
            if (B2P == 1) B2P1.Text = "X";
            if (B3P == 1) B3P1.Text = "X";
            if (B4P == 1) B4P1.Text = "X";
            if (B5P == 1) B5P1.Text = "X";
            if (B6P == 1) B6P1.Text = "X";
            if (B7P == 1) B7P1.Text = "X";
            if (B8P == 1) B8P1.Text = "X";
            if (B9P == 1) B9P1.Text = "X";
            
        }
        public static int B1P = 0; public static int B2P = 0; public static int B3P = 0;
        public static int B4P = 0; public static int B5P = 0; public static int B6P = 0; /*1 - X, 2 - O*/
        public static int B7P = 0; public static int B8P = 0; public static int B9P = 0;
        
        private void B2P1_Click(object sender, EventArgs e)
        {
            if (B2P == 0) B2P = 2;
            if (B1P == 2) B1P1.Text = "O";
            if (B2P == 2) B2P1.Text = "O";
            if (B3P == 2) B3P1.Text = "O";
            if (B4P == 2) B4P1.Text = "O";
            if (B5P == 2) B5P1.Text = "O";
            if (B6P == 2) B6P1.Text = "O";
            if (B7P == 2) B7P1.Text = "O";
            if (B8P == 2) B8P1.Text = "O";
            if (B9P == 2) B9P1.Text = "O";
            if (B1P == 1) B1P1.Text = "X";
            if (B2P == 1) B2P1.Text = "X";
            if (B3P == 1) B3P1.Text = "X";
            if (B4P == 1) B4P1.Text = "X";
            if (B5P == 1) B5P1.Text = "X";
            if (B6P == 1) B6P1.Text = "X";
            if (B7P == 1) B7P1.Text = "X";
            if (B8P == 1) B8P1.Text = "X";
            if (B9P == 1) B9P1.Text = "X";
            Player1 P1 = new Player1();
            P1.ShowDialog();
            if (B1P == 2 && B2P == 2 && B3P == 2 ||
                B1P == 2 && B4P == 2 && B7P == 2 ||
                B1P == 2 && B5P == 2 && B9P == 2 ||
                B2P == 2 && B5P == 2 && B8P == 2 ||
                B3P == 2 && B6P == 2 && B9P == 2 ||
                B4P == 2 && B5P == 2 && B6P == 2 ||
                B7P == 2 && B8P == 2 && B9P == 2)
            {
                EndingScreen.victor = 2; EndingScreen E = new EndingScreen(); E.Show();
            }
        }

        private void B3P1_Click(object sender, EventArgs e)
        {
            if (B3P == 0) B3P = 2;
            if (B1P == 2) B1P1.Text = "O";
            if (B2P == 2) B2P1.Text = "O";
            if (B3P == 2) B3P1.Text = "O";
            if (B4P == 2) B4P1.Text = "O";
            if (B5P == 2) B5P1.Text = "O";
            if (B6P == 2) B6P1.Text = "O";
            if (B7P == 2) B7P1.Text = "O";
            if (B8P == 2) B8P1.Text = "O";
            if (B9P == 2) B9P1.Text = "O";
            if (B1P == 1) B1P1.Text = "X";
            if (B2P == 1) B2P1.Text = "X";
            if (B3P == 1) B3P1.Text = "X";
            if (B4P == 1) B4P1.Text = "X";
            if (B5P == 1) B5P1.Text = "X";
            if (B6P == 1) B6P1.Text = "X";
            if (B7P == 1) B7P1.Text = "X";
            if (B8P == 1) B8P1.Text = "X";
            if (B9P == 1) B9P1.Text = "X";
            Player1 P1 = new Player1();
            P1.ShowDialog();
            if (B1P == 2 && B2P == 2 && B3P == 2 ||
                B1P == 2 && B4P == 2 && B7P == 2 ||
                B1P == 2 && B5P == 2 && B9P == 2 ||
                B2P == 2 && B5P == 2 && B8P == 2 ||
                B3P == 2 && B6P == 2 && B9P == 2 ||
                B4P == 2 && B5P == 2 && B6P == 2 ||
                B7P == 2 && B8P == 2 && B9P == 2)
            {
                EndingScreen.victor = 2; EndingScreen E = new EndingScreen(); E.Show();
            }
        }

        private void B4P1_Click(object sender, EventArgs e)
        {
            if (B4P == 0) B4P = 2;
            if (B1P == 2) B1P1.Text = "O";
            if (B2P == 2) B2P1.Text = "O";
            if (B3P == 2) B3P1.Text = "O";
            if (B4P == 2) B4P1.Text = "O";
            if (B5P == 2) B5P1.Text = "O";
            if (B6P == 2) B6P1.Text = "O";
            if (B7P == 2) B7P1.Text = "O";
            if (B8P == 2) B8P1.Text = "O";
            if (B9P == 2) B9P1.Text = "O";
            if (B1P == 1) B1P1.Text = "X";
            if (B2P == 1) B2P1.Text = "X";
            if (B3P == 1) B3P1.Text = "X";
            if (B4P == 1) B4P1.Text = "X";
            if (B5P == 1) B5P1.Text = "X";
            if (B6P == 1) B6P1.Text = "X";
            if (B7P == 1) B7P1.Text = "X";
            if (B8P == 1) B8P1.Text = "X";
            if (B9P == 1) B9P1.Text = "X";
            Player1 P1 = new Player1();
            P1.ShowDialog();
            if (B1P == 2 && B2P == 2 && B3P == 2 ||
                B1P == 2 && B4P == 2 && B7P == 2 ||
                B1P == 2 && B5P == 2 && B9P == 2 ||
                B2P == 2 && B5P == 2 && B8P == 2 ||
                B3P == 2 && B6P == 2 && B9P == 2 ||
                B4P == 2 && B5P == 2 && B6P == 2 ||
                B7P == 2 && B8P == 2 && B9P == 2)
            {
                EndingScreen.victor = 2; EndingScreen E = new EndingScreen(); E.Show();
            }
        }

        private void B5P1_Click(object sender, EventArgs e)
        {
            if (B5P == 0) B5P = 2;
            if (B1P == 2) B1P1.Text = "O";
            if (B2P == 2) B2P1.Text = "O";
            if (B3P == 2) B3P1.Text = "O";
            if (B4P == 2) B4P1.Text = "O";
            if (B5P == 2) B5P1.Text = "O";
            if (B6P == 2) B6P1.Text = "O";
            if (B7P == 2) B7P1.Text = "O";
            if (B8P == 2) B8P1.Text = "O";
            if (B9P == 2) B9P1.Text = "O";
            if (B1P == 1) B1P1.Text = "X";
            if (B2P == 1) B2P1.Text = "X";
            if (B3P == 1) B3P1.Text = "X";
            if (B4P == 1) B4P1.Text = "X";
            if (B5P == 1) B5P1.Text = "X";
            if (B6P == 1) B6P1.Text = "X";
            if (B7P == 1) B7P1.Text = "X";
            if (B8P == 1) B8P1.Text = "X";
            if (B9P == 1) B9P1.Text = "X";
            Player1 P1 = new Player1();
            P1.ShowDialog();
            if (B1P == 2 && B2P == 2 && B3P == 2 ||
                B1P == 2 && B4P == 2 && B7P == 2 ||
                B1P == 2 && B5P == 2 && B9P == 2 ||
                B2P == 2 && B5P == 2 && B8P == 2 ||
                B3P == 2 && B6P == 2 && B9P == 2 ||
                B4P == 2 && B5P == 2 && B6P == 2 ||
                B7P == 2 && B8P == 2 && B9P == 2)
            {
                EndingScreen.victor = 2; EndingScreen E = new EndingScreen(); E.Show();
            }
        }

        private void B6P1_Click(object sender, EventArgs e)
        {
            if (B6P == 0) B6P = 2;
            if (B1P == 2) B1P1.Text = "O";
            if (B2P == 2) B2P1.Text = "O";
            if (B3P == 2) B3P1.Text = "O";
            if (B4P == 2) B4P1.Text = "O";
            if (B5P == 2) B5P1.Text = "O";
            if (B6P == 2) B6P1.Text = "O";
            if (B7P == 2) B7P1.Text = "O";
            if (B8P == 2) B8P1.Text = "O";
            if (B9P == 2) B9P1.Text = "O";
            if (B1P == 1) B1P1.Text = "X";
            if (B2P == 1) B2P1.Text = "X";
            if (B3P == 1) B3P1.Text = "X";
            if (B4P == 1) B4P1.Text = "X";
            if (B5P == 1) B5P1.Text = "X";
            if (B6P == 1) B6P1.Text = "X";
            if (B7P == 1) B7P1.Text = "X";
            if (B8P == 1) B8P1.Text = "X";
            if (B9P == 1) B9P1.Text = "X";
            Player1 P1 = new Player1();
            P1.ShowDialog();
            if (B1P == 2 && B2P == 2 && B3P == 2 ||
                B1P == 2 && B4P == 2 && B7P == 2 ||
                B1P == 2 && B5P == 2 && B9P == 2 ||
                B2P == 2 && B5P == 2 && B8P == 2 ||
                B3P == 2 && B6P == 2 && B9P == 2 ||
                B4P == 2 && B5P == 2 && B6P == 2 ||
                B7P == 2 && B8P == 2 && B9P == 2)
            {
                EndingScreen.victor = 2; EndingScreen E = new EndingScreen(); E.Show();
            }
        }

        private void B7P1_Click(object sender, EventArgs e)
        {
            if (B7P == 0) B7P = 2;
            if (B1P == 2) B1P1.Text = "O";
            if (B2P == 2) B2P1.Text = "O";
            if (B3P == 2) B3P1.Text = "O";
            if (B4P == 2) B4P1.Text = "O";
            if (B5P == 2) B5P1.Text = "O";
            if (B6P == 2) B6P1.Text = "O";
            if (B7P == 2) B7P1.Text = "O";
            if (B8P == 2) B8P1.Text = "O";
            if (B9P == 2) B9P1.Text = "O";
            if (B1P == 1) B1P1.Text = "X";
            if (B2P == 1) B2P1.Text = "X";
            if (B3P == 1) B3P1.Text = "X";
            if (B4P == 1) B4P1.Text = "X";
            if (B5P == 1) B5P1.Text = "X";
            if (B6P == 1) B6P1.Text = "X";
            if (B7P == 1) B7P1.Text = "X";
            if (B8P == 1) B8P1.Text = "X";
            if (B9P == 1) B9P1.Text = "X";
            Player1 P1 = new Player1();
            P1.ShowDialog();
            if (B1P == 2 && B2P == 2 && B3P == 2 ||
                B1P == 2 && B4P == 2 && B7P == 2 ||
                B1P == 2 && B5P == 2 && B9P == 2 ||
                B2P == 2 && B5P == 2 && B8P == 2 ||
                B3P == 2 && B6P == 2 && B9P == 2 ||
                B4P == 2 && B5P == 2 && B6P == 2 ||
                B7P == 2 && B8P == 2 && B9P == 2)
            {
                EndingScreen.victor = 2; EndingScreen E = new EndingScreen(); E.Show();
            }
        }

        private void B8P1_Click(object sender, EventArgs e)
        {
            if (B8P == 0) B8P = 2;
            if (B1P == 2) B1P1.Text = "O";
            if (B2P == 2) B2P1.Text = "O";
            if (B3P == 2) B3P1.Text = "O";
            if (B4P == 2) B4P1.Text = "O";
            if (B5P == 2) B5P1.Text = "O";
            if (B6P == 2) B6P1.Text = "O";
            if (B7P == 2) B7P1.Text = "O";
            if (B8P == 2) B8P1.Text = "O";
            if (B9P == 2) B9P1.Text = "O";
            if (B1P == 1) B1P1.Text = "X";
            if (B2P == 1) B2P1.Text = "X";
            if (B3P == 1) B3P1.Text = "X";
            if (B4P == 1) B4P1.Text = "X";
            if (B5P == 1) B5P1.Text = "X";
            if (B6P == 1) B6P1.Text = "X";
            if (B7P == 1) B7P1.Text = "X";
            if (B8P == 1) B8P1.Text = "X";
            if (B9P == 1) B9P1.Text = "X";
            Player1 P1 = new Player1();
            P1.ShowDialog();
            if (B1P == 2 && B2P == 2 && B3P == 2 ||
                B1P == 2 && B4P == 2 && B7P == 2 ||
                B1P == 2 && B5P == 2 && B9P == 2 ||
                B2P == 2 && B5P == 2 && B8P == 2 ||
                B3P == 2 && B6P == 2 && B9P == 2 ||
                B4P == 2 && B5P == 2 && B6P == 2 ||
                B7P == 2 && B8P == 2 && B9P == 2)
            {
                EndingScreen.victor = 2; EndingScreen E = new EndingScreen(); E.Show();
            }
        }

        private void B9P1_Click(object sender, EventArgs e)
        {
            if (B9P == 0) B9P = 2;
            if (B1P == 2) B1P1.Text = "O";
            if (B2P == 2) B2P1.Text = "O";
            if (B3P == 2) B3P1.Text = "O";
            if (B4P == 2) B4P1.Text = "O";
            if (B5P == 2) B5P1.Text = "O";
            if (B6P == 2) B6P1.Text = "O";
            if (B7P == 2) B7P1.Text = "O";
            if (B8P == 2) B8P1.Text = "O";
            if (B9P == 2) B9P1.Text = "O";
            if (B1P == 1) B1P1.Text = "X";
            if (B2P == 1) B2P1.Text = "X";
            if (B3P == 1) B3P1.Text = "X";
            if (B4P == 1) B4P1.Text = "X";
            if (B5P == 1) B5P1.Text = "X";
            if (B6P == 1) B6P1.Text = "X";
            if (B7P == 1) B7P1.Text = "X";
            if (B8P == 1) B8P1.Text = "X";
            if (B9P == 1) B9P1.Text = "X";
            Player1 P1 = new Player1();
            P1.ShowDialog();
            if (B1P == 2 && B2P == 2 && B3P == 2 ||
                B1P == 2 && B4P == 2 && B7P == 2 ||
                B1P == 2 && B5P == 2 && B9P == 2 ||
                B2P == 2 && B5P == 2 && B8P == 2 ||
                B3P == 2 && B6P == 2 && B9P == 2 ||
                B4P == 2 && B5P == 2 && B6P == 2 ||
                B7P == 2 && B8P == 2 && B9P == 2)
            {
                EndingScreen.victor = 2; EndingScreen E = new EndingScreen(); E.Show();
            }
        }
    }
}
