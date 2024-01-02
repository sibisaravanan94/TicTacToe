using TicTacToe.Models;

namespace TicTacToe.Stratergies.MakeMoveStratergies
{
    public interface IMakeMoveStratergy
    {
        Cell MakeMove(Board board);
    }
}