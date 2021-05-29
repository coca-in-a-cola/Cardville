using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;
using Cardville.Engine;
using Cardville.Cards;
using System.Windows.Forms;

namespace Cardville.Dungeon.WFViewController
{
    class CardPainter : GameObjectPainter
    {
        public CardPainter(Card card) : base(card)
        {
            var nameLabel = new Label();
            control.Controls.Add(nameLabel);
            nameLabel.Text = card.Name;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Width = control.Width;
            nameLabel.Height = control.Height / 6;
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameLabel.Font = new Font(Label.DefaultFont.FontFamily, 11f, FontStyle.Bold);

            var rarityLabel = RarityLabels.From(card.Rarity);
            control.Controls.Add(rarityLabel);
            rarityLabel.Width = control.Width / 2;
            rarityLabel.Height = control.Height / 6;
            rarityLabel.Location = new Point(control.Width / 20, control.Height - rarityLabel.Height);

            var descriptionLabel = new Label();
            control.Controls.Add(descriptionLabel);
            descriptionLabel.Text = card.Description;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Width = control.Width;
            descriptionLabel.Height = control.Height / 5;
            descriptionLabel.Location = new Point(0, nameLabel.Location.Y
                + (int)(nameLabel.Height * 1.01));
            descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;

            var powerLabel = PowerLabels.From(card);
            control.Controls.Add(powerLabel);
            powerLabel.Width = control.Width;
            powerLabel.Height = control.Height / 6;
            powerLabel.Location = new Point(0, descriptionLabel.Location.Y + (int)(descriptionLabel.Height * 1.01));
            //descriptionLabel.Font = new Font(Label.DefaultFont.FontFamily, 11f, FontStyle.Regular);
        }
    }
}
