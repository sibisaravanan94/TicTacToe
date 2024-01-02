using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.Models
{
    public class Board
    {
        public List<List<Cell>> cells { get; private set; }
        public int size { get; private set; }

        internal Board(int size)
        {
            cells = createBoard(size);
        }

        private List<List<Cell>> createBoard(int size)
        {
            List<Cell> row = Enumerable.Repeat(new Cell(), size).ToList();
            List<List<Cell>> board = Enumerable.Repeat(row, size).ToList();

            return board;
        }

        
    }
}