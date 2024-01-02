using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;
using TicTacToe.Stratergies.MakeMoveStratergies;

namespace TicTacToe
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int boardSize = 3;
            // Arrage
            Game game = Game.GetGameBuilder()
                                .ofSize(boardSize)
                                .withUser(User.GetUserBuilder()
                                            .withName("Sibi")
                                            .ofAge(27)
                                            .email("asf@asdf.com")
                                            .photo(null)
                                            .build()
                                         , Symbol.X)
                                .withBot(Level.Hard, Symbol.O, new RandomMoveStratergy())
                                .Build();

            // Act
            int rowCount = game.board.cells.Count;
            int colCount = game.board.cells[0].Count;

            Cell cell = game.makeMove();
        }
    }
}
