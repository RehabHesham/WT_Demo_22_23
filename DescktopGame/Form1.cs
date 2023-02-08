namespace DescktopGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radP2O_Click(object sender, EventArgs e)
        {
            radP1X.Checked = true;
        }

        private void radP2X_Click(object sender, EventArgs e)
        {
            radP1O.Checked = true;
        }

        private void radP1X_Click(object sender, EventArgs e)
        {
            radP2O.Checked = true;
        }

        private void radP1O_Click(object sender, EventArgs e)
        {
            radP2X.Checked = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txtPlayer1Name.Text == string.Empty || txtPlayer2Name.Text == string.Empty)
            {
                MessageBox.Show("Enter players names first.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //string res = (condition) ? "when true" : "when false";
            DialogResult result = MessageBox.Show($"player {txtPlayer1Name.Text} will play with letter {(radP1X.Checked?"X" : "O")}\n" +
                $"player {txtPlayer2Name.Text} will play with letter {(radP2O.Checked?"O" : "X")}\n","Start Game",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                //new form
                this.Hide();
                string player1 = radP1X.Checked? txtPlayer1Name.Text : txtPlayer2Name.Text ;
                string player2 = radP2O.Checked? txtPlayer2Name.Text : txtPlayer1Name.Text ;
                BoardForm board = new BoardForm(player1 , player2);
                board.ShowDialog();
                this.Close();
            }
        }
    }
}