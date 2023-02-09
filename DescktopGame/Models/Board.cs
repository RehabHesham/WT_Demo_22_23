using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescktopGame.Models
{
    internal class Board
    {
        private int[,] board;

        public Board()
        {
            board = new int[3,3];
        }

        private bool IsAWinner(int player)
        {
            bool win = false;
            // check rows
            for (int i = 0; i < 3; i++)
            {
                win = true;
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != player) win = false;
                }
                if (win) { return true; }
            }

            // check columns
            for (int i = 0; i < 3; i++)
            {
                win = true;
                for (int j = 0; j < 3; j++)
                {
                    if (board[j, i] != player) win = false;
                }
                if (win) { return true; }
            }

            // / diagonal
            win = true;
            for (int i = 0; i < 3; i++)
            {
                if (board[i, i] != player) win = false;
            }
            if (win) { return true; }

            // \ diagonal
            win = true;
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 2 - i] != player) win = false;
            }
            if (win) { return true; }

            return false;
        }


        private bool IsFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0) return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Applay player move on the board
        /// </summary>
        /// <param name="row">defines the row of the wanted cell</param>
        /// <param name="col">defines the col of the wanted cell</param>
        /// <param name="player">defines current player number</param>
        /// <returns>
        /// return int represent the game state
        /// <list type="bullet">
        /// <item>0 : for the draw case (no one wins).</item>
        /// <item>1 : for winning case as current player wins</item>
        /// <item>2 : for waiting the other player turn</item>
        /// </list>
        /// </returns>
        public int ApplyMove(int row, int col, int player)
        {
            board[row, col] = player;
            // wins  => return 1
            if(IsAWinner(player)) { return 1; }
            // Draw  => return 0
            if(IsFull()) { return 0; }
            // wait next move  => return 2
            return 2;
        }
    }
}
