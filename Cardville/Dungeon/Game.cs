using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Core;

namespace Cardville.Dungeon
{
    public class Game
    {
        public GameField Map { get; }
        public int Days { get; private set; }
        public GamePhase Phase { get; private set; }
        public Core.Environment Constants { get; private set; }

        public Game()
        {
            Map = new GameField(3, 3);
        }
    }
}
