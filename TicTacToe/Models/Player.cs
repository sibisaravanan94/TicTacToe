namespace TicTacToe.Models
{
    public abstract class Player
    {
        public Symbol symbol { get; set; }

        public abstract Cell play(Board board);
    }
}