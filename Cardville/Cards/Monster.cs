using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Dungeon;

namespace Cardville.Cards
{
    public class Monster : Card
    {
        public double Pursuit { get; protected set; }
        public Monster(Game game, CardTemplate template, int level) : base(game, template, level)
        {
        }
    }
}
