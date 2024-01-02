namespace TicTacToe.Models
{
    public class Cell
    {
        public Symbol? symbol { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        internal Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}