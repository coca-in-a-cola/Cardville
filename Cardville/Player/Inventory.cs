using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using Cardville.Cards;
using Cardville.Dungeon;

namespace Cardville.Player
{
    public class Inventory
    {
        private PlayerObject player;
        private Spawner spawner;

        public int MaxSize { get; private set; }
        public int Size { get => items.Count; }

        public event Update OnUpdate;

        private readonly List<Item> items;
        private int wornCount;
        private readonly List<bool> worn;

        private readonly Queue<Item> tempq;

        public Inventory (PlayerObject player)
        {
            this.player = player;
            items = new List<Item>();
            worn = new List<bool>();

            tempq = new Queue<Item>();

            spawner = new Spawner(player.Game);
            
            for (int i = 0; i < 2; ++i)
            {
                var startLoot = (Equipment)spawner.GetRandomObjectOfType(GameObjectType.Equipment);
                AddItem(startLoot);
                Wear(startLoot);
            }

            OnUpdate?.Invoke();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            worn.Add(false);
            tempq.Enqueue(item);
            OnUpdate?.Invoke();
        }

        public void RemoveLast()
        {
            var last = tempq.Dequeue();
            RemoveItem(last);
        }

        public void RemoveItem(Item item)
        {
            Unwear(item);

            var index = items.IndexOf(item);
            items.RemoveAt(index);
            worn.RemoveAt(index);

            OnUpdate?.Invoke();
        }

        public void Wear(Item item)
        {
            var index = items.IndexOf(item);
            if (item is Equipment
                && wornCount < player.MaxEquipItems
                && index != -1 && !worn[index])
            {
                player.AddPower(item.Power);
                worn[index] = true;
                wornCount++;
            }

            OnUpdate?.Invoke();
        }

        public void Unwear(Item item)
        {
            var index = items.IndexOf(item);
            if (index != -1 && worn[index])
            {
                player.RemovePower(item.Power);
                worn[index] = false;
                wornCount--;
            }

            OnUpdate?.Invoke();
        }

        public IEnumerable<KeyValuePair<Item, bool>> GetItems()
        {
            for (int i = 0; i < items.Count; ++i)
                yield return new KeyValuePair<Item, bool>(items[i], worn[i]);
        }
    }
}
