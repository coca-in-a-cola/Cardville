using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cardville.Cards;
using Cardville.Engine;

namespace Cardville.Dungeon.WFViewController
{
    public partial class CardControl : RoomControl
    {
        public readonly InteractiveGameObject gameObject;
        public CardControl(Card card)
        {
            gameObject = card;
            InitializeComponent();
            this.nameLabel.Text = card.Name;
            this.rarityColorBorder.BackColor = RarityLabels.GetColor(card.Rarity);
            typeLabel.Text = TypeLabels.GetText(card.Type);

            rarityLabel.UseCustomForeColor = true;
            rarityLabel.ForeColor = RarityLabels.GetColor(card.Rarity);
            rarityLabel.Text = RarityLabels.GetText(card.Rarity);

            descriptionLabel.Text = card.Description;
            powerLabel.Text = PowerLabels.GetText(card);
        }

        private void metroPanel1_Click(object sender, EventArgs e)
        {
            gameObject.Game.Map.SelectItem(gameObject);
        }

        public InteractiveGameObject GetGameObject()
        {
            return gameObject;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
