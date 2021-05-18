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
        public TRPsystem TRP { get; private set; }
    }
}
