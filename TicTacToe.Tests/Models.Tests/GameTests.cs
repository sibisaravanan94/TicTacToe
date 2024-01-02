using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;
using Xunit;
using TicTacToe.Stratergies.MakeMoveStratergies;

namespace TicTacToe.Tests.Models.Tests
{
    public class GameTests
    {
        public readonly int boardSize = 3;
        [Fact]
        public void testBoard()
        {
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
                                .withBot(Level.Hard, Symbol.O)
                                .Build();

            // Act
            int rowCount = game.board.cells.Count;
            int colCount = game.board.cells[0].Count;

            //Cell cell = game.makeMove();

            // Assert
            Assert.Equal(rowCount, boardSize);
            Assert.Equal(colCount, boardSize);
            //Assert.Null(cell.symbol);

        }
    }
}
