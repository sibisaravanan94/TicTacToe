using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Stratergies.MakeMoveStratergies;
using TicTacToe.Stratergies.WinningStratergies;

namespace TicTacToe.Models
{
    public class Game
    {
        public Board board { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public List<IWinningStratergy> WinningStratergies { get; set; } = new List<IWinningStratergy>();

        private Game()
        {

        }
        public static GameBuilder GetGameBuilder()
        {
            return new GameBuilder();
        }
        public class GameBuilder{
            private Game reference;
            public GameBuilder()
            {
                reference = new Game();
            }

            public GameBuilder ofSize(int size)
            {
                reference.board = new Board(size);
                return this;
            }

            public GameBuilder withUser(User user, Symbol symbol)
            {
                reference.Players.Add(new HumanPlayer(user, symbol));
                return this;
            }
            public GameBuilder withBot(Level level, Symbol symbol, IMakeMoveStratergy moveStratergy)
            {
                reference.Players.Add(new BotPlayer(level, symbol, moveStratergy));
                return this;
            }
            public Game Build()
            {
                try
                {
                    Game game = new Game();
                    game.board = reference.board;
                    game.Players = reference.Players;

                    return game;
                }
                finally
                {
                    reference = null;
                }
            }
        }

        public void start()
        {

        }

        public Cell makeMove()
        {
            return Players[1].play(board);
        }

        public bool checkWinner(Cell lastMove)
        {
            foreach(IWinningStratergy stratergy in WinningStratergies)
            {
                if(stratergy.checkWinner(board, lastMove))
                {
                    return true;
                }
            }
            return false;
        }

        public bool checkDraw()
        {
            List<Cell> emptyCells = board.getEmptyCells();
            return (emptyCells.Count == 0);
        }
    }
}
