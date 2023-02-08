using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescktopGame
{
    public partial class BoardForm : Form
    {
        private int[,] Board;
        // x => 1
        // O => 2
        private int CurrentPlayer;
        private int Player1Score;
        private int Player2Score;
        public BoardForm(string player1Name,string player2Name)
        {
            InitializeComponent();
           lblPlayer1Name.Text = player1Name;
           lblPlayer2Name.Text = player2Name;
        }
        private void BoardForm_Load(object sender, EventArgs e)
        {
            Board = new int[3, 3];
            CurrentPlayer = 1;
            Player2Score = 0;
            Player1Score= 0;
        }



        private bool IsAWinner(int player)
        {
            bool win = false;
            // check rows
            for(int i = 0; i< 3; i++)
            {
                win = true;
                for(int j = 0; j< 3; j++)
                {
                    if (Board[i, j] != player) win = false;
                }
                if(win) { return true; }
            }

            // check columns
            for(int i=0; i< 3; i++)
            {
                win = true;
                for(int j = 0; j< 3; j++)
                {
                    if (Board[j, i] != player) win = false;
                }
                if(win) { return true; }
            }

            // / diagonal
            win = true;
            for(int i = 0; i< 3; i++)
            {
                if (Board[i,i] != player) win = false;
            }
            if(win) { return true; }

            // \ diagonal
            win = true;
            for(int i = 0; i< 3; i++)
            {
                if (Board[i,2-i] != player) win = false;
            }
            if(win) { return true; }

            return false;
        }

        private bool IsFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i, j] == 0) return false;
                }
            }
            return true;
        }

        private void btn_row0_col0_Click(object sender, EventArgs e)
        {
            btn_row0_col0.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(0, 0);
            btn_row0_col0.Enabled = false;
        }


        private void DisableBoard(bool isDisabled)
        {
            btn_row0_col0.Enabled = isDisabled;
            btn_row0_col1.Enabled = isDisabled;
            btn_row0_col2.Enabled = isDisabled;
            btn_row1_col0.Enabled = isDisabled;
            btn_row1_col1.Enabled = isDisabled;
            btn_row1_col2.Enabled = isDisabled;
            btn_row2_col0.Enabled = isDisabled;
            btn_row2_col1.Enabled = isDisabled;
            btn_row2_col2.Enabled = isDisabled;
        }


        private void ApplyMove(int row, int col)
        {
            Board[row,col] = CurrentPlayer;
            bool isWinner = IsAWinner(CurrentPlayer);
            if (isWinner)
            {
                MessageBox.Show($"Player {(CurrentPlayer == 1 ? "X" : "O")}");
                if (CurrentPlayer == 1)
                {
                    Player1Score += 1;
                    txtPlayer1Score.Text = Player1Score.ToString();
                }

                else { Player2Score += 1;
                    txtPlayer2Score.Text = Player2Score.ToString();
                }
                DisableBoard(false);
            }
            else
            {
                bool isFull = IsFull();
                if (isFull)
                {
                    MessageBox.Show("No one wins.");
                    DisableBoard(false);
                }
                else
                {
                    CurrentPlayer = CurrentPlayer == 1 ? 2 : 1;
                }
            }
        }

        private void btn_row0_col1_Click(object sender, EventArgs e)
        {
            btn_row0_col1.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(0,1);
            btn_row0_col1.Enabled = false;
        }

        private void btn_row0_col2_Click(object sender, EventArgs e)
        {
            btn_row0_col2.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(0, 2);
            btn_row0_col2.Enabled = false;
        }

        private void btn_row1_col0_Click(object sender, EventArgs e)
        {
            btn_row1_col0.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(1, 0);
            btn_row1_col0.Enabled = false;
        }

        private void btn_row1_col1_Click(object sender, EventArgs e)
        {
            btn_row1_col1.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(1, 1);
            btn_row1_col1.Enabled = false;
        }

        private void btn_row1_col2_Click(object sender, EventArgs e)
        {
            btn_row1_col2.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(1, 2);
            btn_row1_col2.Enabled = false;
        }

        private void btn_row2_col0_Click(object sender, EventArgs e)
        {
            btn_row2_col0.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(2, 0);
            btn_row2_col0.Enabled = false;
        }

        private void btn_row2_col1_Click(object sender, EventArgs e)
        {
            btn_row2_col1.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(2, 1);
            btn_row2_col1.Enabled = false;
        }

        private void btn_row2_col2_Click(object sender, EventArgs e)
        {
            btn_row2_col2.Text = CurrentPlayer == 1 ? "X" : "O";
            ApplyMove(2, 2);
            btn_row2_col2.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Board = new int[3, 3];
            CurrentPlayer = 1;
            ClearBoard();
            DisableBoard(true);
        }

        private void ClearBoard()
        {
            btn_row0_col0.Text = string.Empty;
            btn_row0_col1.Text = string.Empty;
            btn_row0_col2.Text = string.Empty;
            btn_row1_col0.Text = string.Empty;
            btn_row1_col1.Text = string.Empty;
            btn_row1_col2.Text = string.Empty;
            btn_row2_col0.Text = string.Empty;
            btn_row2_col1.Text = string.Empty;
            btn_row2_col2.Text = string.Empty;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnNewGame_Click(null,null);
            Player1Score= 0;
            Player2Score= 0;
            txtPlayer1Score.Text = "0";
            txtPlayer2Score.Text = "0";
        }
    }
}
