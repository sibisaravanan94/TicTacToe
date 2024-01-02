using System;
using System.Collections.Generic;

namespace TicTacToe.Models
{
    public class Board
    {
        public List<List<Cell>> cells { get; private set; }
        public int size { get; private set; }

        public Board(int size)
        {
            createBoard(size);
        }

        private void createBoard(int size)
        {
            throw new NotImplementedException();
        }

        public void start()
        {

        }
    }
}