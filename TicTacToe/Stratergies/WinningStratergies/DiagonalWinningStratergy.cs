using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Stratergies.WinningStratergies
{
    public class DiagonalWinningStratergy : IWinningStratergy
    {
        public bool checkWinner(Board board, Cell lastMove)
        {
            int leftCount = 0;
            int rightCount = 0;
            for (int i = 0; i < board.size; i++)
            {
                if (board.cells[i][i].symbol == lastMove.symbol)
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0, j= board.size-1; i < board.size; i++, j--)
            {
                if (board.cells[i][j].symbol == lastMove.symbol)
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }
            return (leftCount == board.size) || (rightCount==board.size);
        }
    }
}
