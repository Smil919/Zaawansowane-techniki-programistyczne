using System;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class MiniGame : Form
    {
        bool turn = true;
        int turn_count = 0;


        public MiniGame()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Maksym");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn) 
                b.Text = "X";
            else 
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;

            checkforwinner();
        }
        private void checkforwinner()
        {
            bool winner = false;

            if((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                winner = true;
            }
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                winner = true;
            }

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                winner = true;
            }
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                winner = true;
            }

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                winner = true;
            }

            if (winner)
            {
                String gameWinner = "";
                if (turn) 
                    gameWinner = "O";
                else
                    gameWinner = "X";

                MessageBox.Show(gameWinner + " Win!", "Good!");
            }
            else
            {
                if (turn_count == 9) MessageBox.Show("Draw!");
            }
        }
        
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }
    }
}
