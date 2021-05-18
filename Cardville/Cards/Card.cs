using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using Cardville.Core;

namespace Cardville.Cards
{
    public abstract class Card : EffectableEntity
    {
        public CardTemplate Template { get; }
        public string Description { get; protected set; }
        public RarityType Rarity { get => Template.Rarity; }

        protected Card(CardTemplate template, int level) : base (template.Name, level)
        {
            Template = template;
            Description = template.Description;
        }
    }
}
