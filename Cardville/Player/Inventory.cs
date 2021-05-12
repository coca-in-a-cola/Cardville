using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Player
{
    class Inventory
    {
        public int MaxSize { get; private set; }
        private List<IInteractive> items;
    }
}
