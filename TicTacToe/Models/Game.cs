﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Game
    {
        public Board board { get; set; }
        public List<Player> Players { get; set; }
    }
}
