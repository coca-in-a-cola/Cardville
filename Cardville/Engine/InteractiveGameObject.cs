using Cardville.Dungeon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Engine
{
    public class InteractiveGameObject : GameObject, IInteractive
    {
        public InteractiveGameObject(Game game, string name, GameObjectType type) : base(game, name, type)
        {

        }

        public virtual bool CanInteractWith(IInteractive another)
        {
            return false;
        }

        public virtual void InteractWith(IInteractive another)
        {

        }
    }
}
