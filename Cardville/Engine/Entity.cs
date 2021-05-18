using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Engine
{
    public abstract class Entity : IInteractive
    {
        public Guid UUID { get; }
        public string Name { get; protected set; }
        public int Level { get; }
        public virtual int Power { get; protected set; }

        public virtual bool CanInteractWith(IInteractive another)
        {
            return false;
        }
        public virtual void InteractWith(IInteractive another)
        {

        }

        public Entity (string name, int level)
        {
            Name = name;
            Level = level;
            Power = level;
            UUID = Guid.NewGuid();
        }
    }
}
