using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Cards
{
    public class Monster : Card
    {
        public double Pursuit { get; protected set; }
        public Monster(CardTemplate template, int level) : base(template, level)
        {
        }
    }
}
