using System;
using System.Collections.Generic;
using Cardville.Cards;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Player
{
    class Player : Entity
    {
        public readonly Inventory Inventory;
        public int RunAway { get; private set; } 
        public Personality personality { get; }
        public List<IEffect> Effects;

        public override bool CanInteractWith(IInteractive another)
        {
            throw new NotImplementedException();
        }

        public override void InteractWith(IInteractive another)
        {
            throw new NotImplementedException();
        }

        public Player (string name) : base(name, 1)
        {

        }
    }
}
