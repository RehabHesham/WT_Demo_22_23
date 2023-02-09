using DescktopGame.Models;
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
    public partial class ScoresForm : Form
    {
        private DatabaseContext Context;
        public ScoresForm()
        {
            InitializeComponent();
            Context= new DatabaseContext();
        }


        private void ScoresForm_Load(object sender, EventArgs e)
        {
           FillData();
        }

        private void FillData()
        {
            List<GameScore> scores = Context.ReadData();
            dgvGameScores.DataSource = scores;
            dgvGameScores.Columns[2].Visible = false;
        }

        private void dgvGameScores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvGameScores.SelectedCells[0].RowIndex;
            DataGridViewRow data = dgvGameScores.Rows[row];
            if (dgvGameScores.SelectedCells[0].ColumnIndex == 0)
            {
                int id = (int)data.Cells[2].Value;
                int result = Context.DeleteScore(id);
                if(result > 0)
                {
                    MessageBox.Show("Data deleted.");
                    FillData();
                }
            }else if (dgvGameScores.SelectedCells[0].ColumnIndex == 1)
            {
                GameScore gameScore = new GameScore()
                {
                    Id = (int)data.Cells[2].Value,
                    PlayerXName = data.Cells[3].Value.ToString(),
                    PlayerXScore = (int)data.Cells[4].Value,
                    PlayerOName = data.Cells[5].Value.ToString(),
                    PlayerOScore = (int)data.Cells[6].Value,
                    GameDate = Convert.ToDateTime(data.Cells[7].Value),
                };
                int result = Context.UpdateScore(gameScore);
                if(result > 0)
                {
                    MessageBox.Show("Data updated.");
                    FillData();
                }
            }
        }
    }
}
