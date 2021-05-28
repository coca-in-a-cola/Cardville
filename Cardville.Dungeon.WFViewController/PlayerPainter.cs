using Cardville.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Player;
using System.Windows.Forms;
using System.Drawing;

namespace Cardville.Dungeon.WFViewController
{
    class PlayerPainter : GameObjectPainter
    {
        public PlayerPainter(PlayerObject player) : base(player)
        {
            var label = new Label();
            label.Width = control.Width;
            label.BackColor = Color.Transparent;
            label.Height = control.Height / 6;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font(Label.DefaultFont.FontFamily, 11f, FontStyle.Bold);
            label.Text = player.Name;
            control.Controls.Add(label);
        }
    }
}
