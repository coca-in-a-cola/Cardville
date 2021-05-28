using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using System.Drawing;
using System.Windows.Forms;

namespace Cardville.Dungeon.WFViewController
{
    public static class RarityLabels
    {
        private static readonly Dictionary<Rarity, Color> rarityColors
            = new Dictionary<Rarity, Color>()
        {
            { Rarity.Common, Color.Gray },
            { Rarity.Uncommon, Color.FromArgb(51, 133, 198) },
            { Rarity.Rare, Color.Orange },
            { Rarity.Epic, Color.DarkViolet },
            { Rarity.Legendary, Color.FromArgb(255, 198, 10) },
            { Rarity.Mythical, Color.Green },
            { Rarity.Transcendent, Color.FromArgb(255, 0, 255) },
            { Rarity.Relict, Color.IndianRed },
            { Rarity.Godly, Color.Cyan },
        };

        private static readonly Dictionary<Rarity, string> rarityNames
            = new Dictionary<Rarity, string>()
        {
            { Rarity.Common, "Обычная"},
            { Rarity.Uncommon, "Необычная" },
            { Rarity.Rare, "Редкая" },
            { Rarity.Epic, "Эпическая" },
            { Rarity.Legendary, "Легендарная" },
            { Rarity.Mythical, "Мифическая" },
            { Rarity.Transcendent, "Трансцендентная" },
            { Rarity.Relict, "Реликтовая" },
            { Rarity.Godly, "???" },
        };

        public static Label From(Rarity rarity)
        {
            var label = new Label();
            label.Text = rarityNames[rarity];
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            label.ForeColor = rarityColors[rarity];
            label.BackColor = Color.Transparent;
            return label;
        }
    }
}
