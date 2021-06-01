using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cardville.Engine;
using Cardville.Player;

namespace Cardville.Dungeon.WFViewController
{
    public partial class PlayerControl : RoomControl
    {
        public readonly InteractiveGameObject gameObject;
        public PlayerControl(PlayerObject player)
        {
            gameObject = player;
            InitializeComponent();
            this.nameLabel.Text = player.Name;
            powerLabel.Text = PowerLabels.GetText(player);
        }

        public override InteractiveGameObject GetGameObject()
        {
            return gameObject;
        }

        private void metroPanel1_Click_1(object sender, EventArgs e)
        {
            gameObject.Game.Map.SelectItem(gameObject);
        }
    }
}
