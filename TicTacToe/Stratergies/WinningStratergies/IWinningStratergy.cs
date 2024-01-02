using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Stratergies.WinningStratergies
{
    public interface IWinningStratergy
    {
        bool checkWinner(Board board, Cell lastMove);
    }
}
