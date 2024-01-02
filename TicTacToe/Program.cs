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
        public static readonly int boardSize = 3;
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Tic Tac Toe ");
            User user = getUserInputs();

            Game game = createBoard(user);

            game.start();

            game.board.printBoard();

            while (game.gameStatus == GameStatus.In_Progress)
            {
                Console.WriteLine("Next player is {0}", game.Players[game.NextPlayerIndex].symbol);
                game.makeMove();
                game.board.printBoard();
            }

            if(game.gameStatus == GameStatus.Finished)
            {
                Console.WriteLine("Winner is - {0}", game.Winner);
            }
            else
            {
                Console.WriteLine("Match draw");
            }

            Console.ReadLine();
        }

        private static Game createBoard(User user)
        {
            return Game.GetGameBuilder()
                                .ofSize(boardSize)
                                .withUser(user, Symbol.X)
                                .withBot(Level.Hard, Symbol.O)
                                .Build();
        }

        private static User getUserInputs()
        {
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter email : ");
            string email = Console.ReadLine();

            return User.GetUserBuilder()
                          .withName(name)
                          .ofAge(age)
                          .email(email)
                          .photo(null)
                          .build();                           
        }

    }
}
