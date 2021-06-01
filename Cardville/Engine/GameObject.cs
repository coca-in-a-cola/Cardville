using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Dungeon;

namespace Cardville.Engine
{
    public abstract class GameObject
    {
        public readonly GameObjectType Type = GameObjectType.Empty;
        public Guid UUID { get; }
        public string Name { get; protected set; }

        public readonly Game Game;

        private Action Update;
        public event Action OnUpdate
        {
            add { Update += value; }
            remove { Update -= value; }
        }

        public readonly List<GameObject> Chlidren;
        public GameObject Parent { get; private set; }


        public virtual void UpdateSelf()
        {
            Update?.Invoke();
        }

        private GameObject(Game game, string name)
        {
            UUID = Guid.NewGuid();
            Game = game;
            Name = name;
            Chlidren = new List<GameObject>();
            UpdateSelf();
        }

        public GameObject (Game game, string name, GameObjectType type) : this (game, name)
        {
            Type = type;
        }
    }
}
