using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class BotPlayer : Player
    {
        public Level level { get; set; }
        public IMakeMoveStratergy moveStratergy { get; set; }

        public override Cell play(Board board)
        {
            return moveStratergy.MakeMove(board);
        }
    }
}
