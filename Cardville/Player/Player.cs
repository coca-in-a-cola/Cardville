using System;
using System.Collections.Generic;
using Cardville.Cards;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;


namespace Cardville.Player
{
    class Player : EffectableEntity
    {
        public readonly Inventory Inventory;
        public int RunAway { get; private set; } 
        public Personality personality { get; }

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
