using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using System.Windows.Forms;
using System.Drawing;

namespace Cardville.Dungeon.WFViewController
{
    class TypeLabels
    {
        private static readonly Dictionary<GameObjectType, string> typeNames
            = new Dictionary<GameObjectType, string>()
        {
            { GameObjectType.Empty, "-"},
            { GameObjectType.Monster, "Монстр" },
            { GameObjectType.Equipment, "Снаряга" },
        };

        public static Label From(GameObjectType type)
        {
            var label = new Label();
            label.TextAlign = ContentAlignment.MiddleRight;
            label.Font = new Font(Label.DefaultFont, FontStyle.Bold);

            if (typeNames.ContainsKey(type))
                label.Text = typeNames[type];

            return label;
        }
    }
}
