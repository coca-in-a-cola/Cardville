using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Dungeon;

namespace Cardville.Engine
{
    public abstract class Entity : InteractiveGameObject
    {
        public int Level { get; protected set; }
        public virtual int Power { get; protected set; }

        public Entity (Game game, string name, int level, GameObjectType type) : base(game, name, type)
        {
            Level = level;
            if (Power == 0)
                Power = level;
        }
    }
}
