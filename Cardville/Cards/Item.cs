using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Cards
{
    public class Item : Card
    {
        public int Price { get; private set; }
        public Item(CardTemplate template, int level) : base(template, level)
        {

        }

        public override bool CanInteractWith(IInteractive another)
        {
            throw new NotImplementedException();
        }

        public override void InteractWith(IInteractive another)
        {
            throw new NotImplementedException();
        }
    }
}
