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
        public int ID { get; }
        public string Name { get; }
        public RarityType Rarity { get; }
        public string Description { get; }
        public Type CardType { get; }
    }
}
