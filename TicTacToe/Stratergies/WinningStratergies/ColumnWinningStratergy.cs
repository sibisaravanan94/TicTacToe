using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Stratergies.WinningStratergies
{
    public class ColumnWinningStratergy : IWinningStratergy
    {
        public bool checkWinner(Board board, Cell lastMove)
        {
            int count = 0;
            for (int i = 0; i < board.size; i++)
            {
                if (board.cells[i][lastMove.y].symbol == lastMove.symbol)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return (count == board.size);
        }
    }
}
