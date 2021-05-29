using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Dungeon;

namespace Cardville.Engine
{
    public abstract class GameObject : IInteractive
    {
        public readonly GameObjectType Type = GameObjectType.Empty;
        public Guid UUID { get; }
        public string Name { get; protected set; }

        public readonly Game Game;

        public event Action OnDestroy;

        public virtual bool CanInteractWith(IInteractive another)
        {
            return false;
        }

        public virtual void InteractWith(IInteractive another)
        {
            
        }

        public void Destroy()
        {
            OnDestroy();
        }

        private GameObject(Game game, string name)
        {
            UUID = Guid.NewGuid();
            Game = game;
            Name = name;
        }

        public GameObject (Game game, string name, GameObjectType type) : this (game, name)
        {
            Type = type;
        }
    }
}
