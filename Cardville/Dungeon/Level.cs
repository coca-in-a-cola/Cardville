using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Dungeon
{
    public class Level
    {
        public CardMap Map { get; }
        public int Days { get; private set; }
    }
}
