namespace DescktopGame.Models
{
    internal class Game
    {
        public string playerXName;
        public int playerXScore;

        public string playerOName;
        public int playerOScore;

        public int currentPlayer;

        private Board board;
        public Game()
        {
            board = new Board();
            currentPlayer = 1;
            playerOScore = 0;
            playerXScore = 0;
        }

        /// <summary>
        /// Applay player move on the board
        /// </summary>
        /// <param name="row">defines the row of the wanted cell</param>
        /// <param name="col">defines the col of the wanted cell</param>
        /// <returns>
        /// return int represent the game state
        /// <list type="bullet">
        /// <item>0 : for the draw case (no one wins).</item>
        /// <item>1 : for winning case as current player wins</item>
        /// <item>2 : for waiting the other player turn</item>
        /// </list>
        /// </returns>
        public int ApplyMove(int row, int col)
        {
            int result = board.ApplyMove(row, col, currentPlayer);
            switch (result)
            {
                case 0:
                    return 0;
                case 1:
                    if (currentPlayer == 1) { playerXScore += 1; }
                    else { playerOScore += 1; }
                    return 1;
                case 2:
                    currentPlayer = currentPlayer == 1 ? 2 : 1;
                    return 2;
                default: return result;
            }
        }

        public void NewGame()
        {
            board = new Board();
            currentPlayer= 1;
        }
        public void Reset()
        {
            NewGame();
            playerXScore= 0;
            playerOScore= 0;
        }
    }
}
