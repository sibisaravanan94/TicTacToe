using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Game
    {
        public Board board { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();

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
            public GameBuilder withBot(Level level, Symbol symbol)
            {
                reference.Players.Add(new BotPlayer(level, symbol));
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
    }
}
