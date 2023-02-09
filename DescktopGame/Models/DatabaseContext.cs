using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescktopGame.Models
{
    internal class DatabaseContext
    {
        public string ConnectionString { get; set; }
        private SqlConnection connection;

        public DatabaseContext()
        {
            // Define connection
            ConnectionString = "Data Source=DESKTOP-JCFIEDI;Initial Catalog=XOGame;Integrated Security=True";
            connection = new SqlConnection(ConnectionString);
        }

        public List<GameScore> ReadData()
        {
            string commandtext = "select * from GameScores";
            // Define command
            //SqlCommand command = new SqlCommand();
            //command.CommandText = commandtext;
            //command.CommandType = CommandType.Text;
            //command.Connection = connection;

            SqlCommand command = connection.CreateCommand();
            command.CommandText = commandtext;

            // open commection
            connection.Open();

            // execute query
            SqlDataReader reader = command.ExecuteReader();

            // display data
            List<GameScore> results = new List<GameScore>();
            while (reader.Read())
            {
                GameScore score = new GameScore() { 
                Id = (int)reader[0],
                PlayerXName = (string)reader[1],
                PlayerXScore= (int)reader[2],
                PlayerOName= (string)reader[3],
                PlayerOScore = (int)reader[4],
                GameDate = Convert.ToDateTime(reader[5]),
                };
                results.Add(score);
            }

            // close connection
            connection.Close();

            return results;
        }

        public int SaveScore(GameScore gameScore)
        {
            // Define command
            //string commandtext = $"insert into GameScores values" +
            //    $"('{gameScore.PlayerXName}',{gameScore.PlayerXScore}," +
            //    $"'{gameScore.PlayerOName}',{gameScore.PlayerOScore},'{gameScore.GameDate}')";

            string commandtext = "insert into GameScores values(@Xname,@Xscore,@Oname,@Oscore,@gameDate)";
            // sql injection
            SqlCommand command = new SqlCommand(commandtext, connection);
            command.Parameters.Add(new SqlParameter("Xname", gameScore.PlayerXName));
            command.Parameters.Add(new SqlParameter("Xscore", gameScore.PlayerXScore));
            command.Parameters.Add(new SqlParameter("Oname", gameScore.PlayerOName));
            command.Parameters.Add(new SqlParameter("Oscore", gameScore.PlayerOScore));
            command.Parameters.Add(new SqlParameter("gameDate", gameScore.GameDate));

            // SqlParameter parameter = new SqlParameter();

            // open connection
            connection.Open();
            // execute query
            int result = command.ExecuteNonQuery();
            // display data

            // close connection
            connection.Close();
            return result;
        }

        public int DeleteScore(int id)
        {
            string cmd = "delete from GameScores where id = @id";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("id", id);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int UpdateScore(GameScore gameScore)
        {
            string cmd = "update GameScores set PlayerXName = @Xname, PlayerXScore = @Xscore, PlayerOName = @Oname, PlayerOScore = @Oscore, GameDate = @gameDate where Id = @id";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("id", gameScore.Id);
            command.Parameters.Add(new SqlParameter("Xname", gameScore.PlayerXName));
            command.Parameters.Add(new SqlParameter("Xscore", gameScore.PlayerXScore));
            command.Parameters.Add(new SqlParameter("Oname", gameScore.PlayerOName));
            command.Parameters.Add(new SqlParameter("Oscore", gameScore.PlayerOScore));
            command.Parameters.Add(new SqlParameter("gameDate", gameScore.GameDate));

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
    }
}
