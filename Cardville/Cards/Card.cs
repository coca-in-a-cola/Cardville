using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using Cardville.Dungeon;
using Cardville.Core;

namespace Cardville.Cards
{
    public abstract class Card : EffectableEntity
    {
        public CardTemplate Template { get; }
        public string Description { get => Template.Description; }
        public Rarity Rarity { get => Template.Rarity; }

        protected Card (Game game, CardTemplate template, int level)
            : base (game, template.Name, level, template.CardType)
        {
            Template = template;
        }

        public static Card FromTemplate(Game game, CardTemplate template, int level)
        {
            // не работает
            // var type = typeof(Card).Assembly.GetType("Cards." + template.CardType.ToString());
            // var ctor = type.GetConstructor(new[] { typeof(Game), typeof(CardTemplate), typeof(int) });
            // return (Card)ctor.Invoke(new object[] { game, template, level });

            switch (template.CardType)
            {
                // A single zero value.
                case GameObjectType.Monster:
                    return new Monster(game, template, level);
                case GameObjectType.Equipment:
                    return new Equipment(game, template, level);
                // A value that is neither an integer nor a collection.
                default:
                    throw new InvalidOperationException("unknown item type");
            }

        }
    }
}
