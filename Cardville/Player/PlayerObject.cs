using System;
using System.Collections.Generic;
using Cardville.Cards;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using Cardville.Dungeon;


namespace Cardville.Player
{
    public class PlayerObject : EffectableEntity
    {
        public readonly Inventory Inventory;
        public int RunAway { get; private set; }
        public int MaxEquipItems { get => 5; }
        //public Personality personality { get; }

        public override bool CanInteractWith(IInteractive another)
        {
            if (another is Item || another is Monster || another is EmptyCell)
                return true;
            return false;
        }

        public override void InteractWith(IInteractive another)
        {
            if (another is Item)
            {
                Inventory.AddItem((Item)another);
            }
        }

        public PlayerObject (Game game, string name) : base(game, name, 1, GameObjectType.Player)
        {
            Inventory = new Inventory(this);
        }

        public void AddPower(int power)
        {
            this.Power -= power;
        }

        public void RemovePower(int power)
        {
            this.Power += power;
        }
    }
}
