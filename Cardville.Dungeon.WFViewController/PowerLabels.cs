using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using System.Windows.Forms;
using System.Drawing;
using Cardville.Cards;

namespace Cardville.Dungeon.WFViewController
{
    class PowerLabels
    {
        private static readonly Dictionary<GameObjectType, string> powerPhrases
            = new Dictionary<GameObjectType, string>()
            {
                {GameObjectType.Monster, "Сила {0}"},
                {GameObjectType.Equipment, "Бонус +{0}"},
                {GameObjectType.Player, "Сила {0}"}
            };

        public static Label From(Card card)
        {
            var label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font(Label.DefaultFont.FontFamily, 11f, FontStyle.Bold);

            if (powerPhrases.ContainsKey(card.Type))
                label.Text = string.Format(powerPhrases[card.Type], card.Power);

            return label;
        }

        public static string GetText(Entity entity)
        {
            if (powerPhrases.ContainsKey(entity.Type))
                return string.Format(powerPhrases[entity.Type], entity.Power);

            return "";
        }
    }
}
