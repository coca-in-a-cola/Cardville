using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using Cardville.Dungeon;

namespace Cardville.Cards
{
    public class Item : Card
    {
        public int Price { get; protected set; }
        public Item(Game game, CardTemplate template, int level) : base(game, template, level)
        {
        }
    }
}
