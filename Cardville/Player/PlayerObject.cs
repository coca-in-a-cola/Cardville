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
                if (Inventory.Size == MaxEquipItems)
                    Inventory.RemoveLast();

                Inventory.AddItem((Item)another);
                Inventory.Wear((Item)another);
            }

            if (another is Monster)
            {
                if (Power > ((Monster)another).Power)
                {
                    var levelUp = ((Monster)another).Level / 10 + 1;
                    Level += levelUp;
                    Power += levelUp;
                }
                    
                else
                {
                    Game.GameOver();
                }
            }

            Game.NextDay();
        }

        public PlayerObject (Game game, string name) : base(game, name, 1, GameObjectType.Player)
        {
            Inventory = new Inventory(this);
        }

        public void AddPower(int power)
        {
            this.Power += power;
        }

        public void RemovePower(int power)
        {
            this.Power -= power;
        }
    }
}
