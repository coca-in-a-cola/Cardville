using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Cards
{
    public abstract class Card : Entity
    {
        public CardTemplate Template { get; }
        public string Description { get; protected set; }
        public RaritySystem.Rarity Rarity { get => Template.Rarity; }

        public List<IEffect> ActiveEffects;
        public Card(CardTemplate template, int level) : base (template.Name, level)
        {
            Template = template;
            Description = template.Description;
        }
    }
}
