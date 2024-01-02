using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Stratergies.MakeMoveStratergies;
using TicTacToe.Stratergies.WinningStratergies;
using TicTacToe.Exceptions;

namespace TicTacToe.Models
{
    public class Game
    {
        public Board board { get; private set; }
        public List<Player> Players { get; private set; } = new List<Player>();
        public List<IWinningStratergy> WinningStratergies { get; set; } = new List<IWinningStratergy>();
        public GameStatus gameStatus { get; private set; }
        public int NextPlayerIndex { get; private set; } = 0;
        public Player Winner { get; private set; }
        public static readonly int noOfPlayers = 2;

        #region Builder
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
                    validate();
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

            private void validate()
            {
                if(reference.Players.Count != noOfPlayers)
                {
                    throw new InvalidPlayersListException();
                }
                if(reference.Players.Select(player => player.symbol).ToHashSet().Count != noOfPlayers)
                {
                    throw new InvalidSymbolException();
                }
            }
        }

        #endregion

        public void start()
        {
            // Set Random Player to start
            Random random = new Random();
            NextPlayerIndex = random.Next(0, board.size - 1);

            // Set Game Status to in progress
            gameStatus = GameStatus.In_Progress;

            // Get winning stratergies
            WinningStratergies = getWinningStratergies();
        }

        private List<IWinningStratergy> getWinningStratergies()
        {
            return new List<IWinningStratergy>()
            {
                    new RowWinningStratergy()
                    , new ColumnWinningStratergy()
                    , new DiagonalWinningStratergy() 
            };
        }

        public void makeMove()
        {
            Cell lastMove = Players[NextPlayerIndex].play(board);

            validateMove(lastMove);

            board.updateMove(lastMove, Players[NextPlayerIndex].symbol);

            if(checkWinner(lastMove))
            {
                gameStatus = GameStatus.Finished;
                Winner = Players[NextPlayerIndex];
                return;
            }

            if (checkDraw())
            {
                gameStatus = GameStatus.Drawn;
                return;
            }

            updateNextPlayerIndex();
        }

        private void updateNextPlayerIndex()
        {
            NextPlayerIndex = (NextPlayerIndex + 1) % Players.Count;
        }

        private void validateMove(Cell lastMove)
        {
            if (!board.isEmpty(lastMove))
            {
                throw new InvalidMoveException(lastMove.x, lastMove.y);
            }
        }

        private bool checkWinner(Cell lastMove)
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

        private bool checkDraw()
        {
            List<Cell> emptyCells = board.getEmptyCells();
            return (emptyCells.Count == 0);
        }
    }
}
