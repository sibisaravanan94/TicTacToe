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
            this.size = size;
            cells = createBoard(size);
        }

        private List<List<Cell>> createBoard(int size)
        {
            List<List<Cell>> board = new List<List<Cell>>();
            for (int i =0; i<size; i++)
            {
                List<Cell> row = new List<Cell>();
                for (int j = 0; j<size; j++)
                {
                    row.Add(new Cell(i, j));
                }
                board.Add(row);
            }
            
            return board;
        }

        internal void printBoard()
        {
            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    if (cells[i][j] != null)
                    {
                        string val = cells[i][j].symbol.ToString();
                        Console.Write("| "+val+" |");
                    }
                    else
                    {
                        Console.Write("|  :  |");
                    }

                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        public List<Cell> getEmptyCells()
        {
            List<Cell> emptyCells = cells.SelectMany(cells => cells).Select(cell => cell).Where(cell => cell.symbol == null).ToList();
            return emptyCells;
                
        }

        internal bool isEmpty(Cell lastMove)
        {
            return cells[lastMove.x][lastMove.y].symbol == null;
        }

        internal void updateMove(Cell lastMove, Symbol symbol)
        {
            cells[lastMove.x][lastMove.y].symbol = symbol;
            lastMove.symbol = symbol;
        }
    }
}