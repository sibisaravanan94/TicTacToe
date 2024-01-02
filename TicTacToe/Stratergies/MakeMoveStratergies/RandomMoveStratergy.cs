using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Stratergies.MakeMoveStratergies
{
    public class RandomMoveStratergy : IMakeMoveStratergy
    {
        public Cell MakeMove(Board board)
        {
            List<Cell> emptyCells = board.getEmptyCells();
            Random random = new Random();
            int index = random.Next(0, emptyCells.Count);
            return emptyCells[index];
        }

        
    }
}
