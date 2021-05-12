using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville
{
    public abstract class Entity : IInteractive
    {
        public Guid UUID { get; }
        public string Name { get; protected set; }
        public int Level { get; }
        public virtual int Power 
        {
            get
                => Level;
            protected set { }
        }

        public abstract bool CanInteractWith(IInteractive another);
        public abstract void InteractWith(IInteractive another);

        public Entity (string name, int level)
        {
            Name = name;
            Level = level;
            UUID = Guid.NewGuid();
        }
    }
}
