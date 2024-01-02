using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Stratergies.MakeMoveStratergies
{
    public class FirstCellStratergy : IMakeMoveStratergy
    {
        public Cell MakeMove(Board board)
        {
            List<Cell> emptyCells = board.getEmptyCells();
            return new Cell(emptyCells[0].x, emptyCells[0].y);
        }
    }
}
