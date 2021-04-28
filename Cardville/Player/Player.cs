using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Player
{
    class Player : ICard
    {
        public readonly Inventory Inventory;

        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }
        public int RunAway { get; private set; } 
        public Personality personality { get; }
        public List<IEffect> Effects;

        public bool CanInteractWith(ICard another)
        {
            throw new NotImplementedException();
        }

        public void InteractWith(ICard another)
        {
            throw new NotImplementedException();
        }
    }
}
