using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Stratergies.MakeMoveStratergies;

namespace TicTacToe.Models
{
    public class BotPlayer : Player
    {
        internal BotPlayer(Level level, Symbol symbol) : base(symbol)
        {
            this.level = level;

            switch (level)
            {
                case Level.Easy:
                case Level.Medium:
                    this.moveStratergy = new FirstCellStratergy();
                    break;
                case Level.Hard:
                    this.moveStratergy = new RandomMoveStratergy();
                    break;
            }
        }

        public Level level { get; set; }
        public IMakeMoveStratergy moveStratergy { get; set; }

        public override Cell play(Board board)
        {
            return moveStratergy.MakeMove(board);
        }
    }
}
