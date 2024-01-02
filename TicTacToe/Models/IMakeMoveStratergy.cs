namespace TicTacToe.Models
{
    public interface IMakeMoveStratergy
    {
        Cell MakeMove(Board board);
    }
}