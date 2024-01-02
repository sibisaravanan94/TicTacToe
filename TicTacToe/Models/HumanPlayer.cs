using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class HumanPlayer : Player
    {
        public User user { get; set; }
        internal HumanPlayer(User user, Symbol symbol) : base(symbol)
        {
            this.user = user;
        }

        public override Cell play(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
