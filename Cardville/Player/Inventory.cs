using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using Cardville.Cards;

namespace Cardville.Player
{
    public class Inventory
    {
        private PlayerObject player;
        public int MaxSize { get; private set; }
        public int Size { get => items.Count; }

        public event Update OnUpdate;

        private readonly List<Item> items;
        private int wornCount;
        private readonly List<bool> worn;

        public Inventory (PlayerObject player)
        {
            this.player = player;
            items = new List<Item>();
            worn = new List<bool>();
            OnUpdate?.Invoke();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            worn.Add(false);
            OnUpdate?.Invoke();
        }

        public void RemoveItem(Item item)
        {
            Unwear(item);
            items.Remove(item);
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
