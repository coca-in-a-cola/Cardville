using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cardville.Cards
{
    public class CardTemplate {
        public int ID { get; }
        public string Name { get; }
        public RaritySystem.Rarity Rarity { get; }
        public string Description { get; }
        public Image Picture { get; }
        public Type CardType { get; }
    }
}
