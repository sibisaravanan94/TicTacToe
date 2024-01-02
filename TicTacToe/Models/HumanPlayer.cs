using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class HumanPlayer : Player
    {
        public User user { get; set; }
        internal HumanPlayer(User user, Symbol symbol) : base(symbol)
        {
            this.user = user;
        }

        public override Cell play(Board board)
        {
            Console.WriteLine("Enter row and column");
            int row = Convert.ToInt32(Console.ReadLine());
            int col = Convert.ToInt32(Console.ReadLine());
            validateUserInput(row, col, board);
            return new Cell(board.cells[row][col].x, board.cells[row][col].y);
        }

        private void validateUserInput(int row, int col, Board board)
        {
            if(row <0 || row>=board.size || col<0 || col >= board.size)
            {
                throw new InvalidBoardCellException();
            }
        }
    }
}
