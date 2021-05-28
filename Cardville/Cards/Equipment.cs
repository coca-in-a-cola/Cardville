using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using Cardville.Dungeon;

namespace Cardville.Cards
{
    public class Equipment : Item
    {
        public Equipment(Game game, CardTemplate template, int level) : base(game, template, level)
        {

        }
    }
}
