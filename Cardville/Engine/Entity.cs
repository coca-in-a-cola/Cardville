using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Dungeon;

namespace Cardville.Engine
{
    public abstract class Entity : GameObject
    {
        public int Level { get; }
        public virtual int Power { get; protected set; }

        public Entity (Game game, string name, int level, GameObjectType type) : base(game, name, type)
        {
            Level = level;
            Power = level;
        }
    }
}
