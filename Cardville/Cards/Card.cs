using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cardville.Cards
{
    public class Card : ICard
    {
        public CardTemplate Template { get; }
        public RaritySystem.Rarity Rarity { get => Template.Rarity; }
        public Guid UUID { get; }
        public string Name { get; private set;}
        public string Description { get; private set; }
        public Image Picture { get => Template.Picture; }
        public int Level { get; private set; }
        public int Power { get; private set; }
        public List<IEffect> ActiveEffects;
        bool ICard.CanInteractWith(ICard another)
        {
            throw new NotImplementedException();
        }

        void ICard.InteractWith(ICard another)
        {
            throw new NotImplementedException();
        }

        public Card(CardTemplate template, ICardGeneratorData cardGenerator)
        {
            UUID = Guid.NewGuid();
            Template = template;
        }
    }
}
