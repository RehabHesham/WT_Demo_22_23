using DescktopGame.Models;

namespace DescktopGame
{
    public partial class BoardForm : Form
    {
        private Game myGame;
        public BoardForm(string player1Name, string player2Name)
        {
            InitializeComponent();
            myGame = new Game()
            {
                playerXName = player1Name,
                playerOName = player2Name,
            };
            lblPlayer1Name.Text = player1Name;
            lblPlayer2Name.Text = player2Name;
        }
        private void BoardForm_Load(object sender, EventArgs e)
        {

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

        private void ApplyMove(int row, int col, Button button)
        {
            button.Text = myGame.currentPlayer == 1 ? "X" : "O";
            button.Enabled = false;

            int result = myGame.ApplyMove(row, col);
            switch (result)
            {
                case 0:
                    MessageBox.Show("No one wins.");
                    DisableBoard(false);
                    break;
                case 1:
                    MessageBox.Show($"Player {(myGame.currentPlayer == 1 ? "X" : "O")}");
                    txtPlayer1Score.Text = myGame.playerXScore.ToString();
                    txtPlayer2Score.Text = myGame.playerOScore.ToString();
                    DisableBoard(false);
                    break;
                case 2:
                    break;
            }
        }


        #region Buttons

        private void btn_row0_col0_Click(object sender, EventArgs e)
        {
            ApplyMove(0, 0, (Button)sender);
        }

        private void btn_row0_col1_Click(object sender, EventArgs e)
        {
            ApplyMove(0, 1, (Button)sender);
        }

        private void btn_row0_col2_Click(object sender, EventArgs e)
        {
            ApplyMove(0, 2, (Button)sender);
        }

        private void btn_row1_col0_Click(object sender, EventArgs e)
        {
            ApplyMove(1, 0, (Button)sender);
        }

        private void btn_row1_col1_Click(object sender, EventArgs e)
        {
            ApplyMove(1, 1, (Button)sender);
        }

        private void btn_row1_col2_Click(object sender, EventArgs e)
        {
            ApplyMove(1, 2, (Button)sender);
        }

        private void btn_row2_col0_Click(object sender, EventArgs e)
        {
            ApplyMove(2, 0, (Button)sender);
        }

        private void btn_row2_col1_Click(object sender, EventArgs e)
        {
            ApplyMove(2, 1, (Button)sender);
        }

        private void btn_row2_col2_Click(object sender, EventArgs e)
        {
            ApplyMove(2, 2, (Button)sender);
        }

        #endregion


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            myGame.NewGame();
            ClearBoard();
            DisableBoard(true);
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            myGame.Reset();
            txtPlayer1Score.Text = "0";
            txtPlayer2Score.Text = "0";
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            // validate data
            // context
            DatabaseContext context = new DatabaseContext();
            GameScore gameScore = new GameScore()
            {
                PlayerXName = myGame.playerXName,
                PlayerOName= myGame.playerOName,
                PlayerXScore = myGame.playerXScore,
                PlayerOScore= myGame.playerOScore,
                GameDate = DateTime.Now
            };
            int result = context.SaveScore(gameScore);
            if(result > 0)
            {
                MessageBox.Show("Data saved successfully.");
                this.Hide();
                ScoresForm scoresForm = new ScoresForm(); 
                scoresForm.ShowDialog();
                this.Close();
            }
        }
    }
}
