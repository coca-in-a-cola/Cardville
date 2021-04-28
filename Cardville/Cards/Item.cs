using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Cards
{
    public class Item : Card
    {
        public new Effect<Item> ActiveEffects;
        public int Price { get; private set; }
        public Item(CardTemplate template) : base(template)
        {

        }
    }
}
