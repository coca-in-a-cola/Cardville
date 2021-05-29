using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Cardville.Engine;
using Cardville.Core;

namespace Cardville.Cards
{
    public class CardTemplate {
        public int ID { get; set; }
        public string Name { get; set; }
        public Rarity Rarity { get; set; }
        public string Description { get; set; }
        public GameObjectType CardType { get; set; }
    }
}
