using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cardville.Dungeon;
using Cardville.Cards;
using Cardville.Player;

namespace Cardville.Dungeon.WFViewController
{
    public partial class DungeonControl : MetroFramework.Controls.MetroUserControl
    {
        private DungeonMap dungeon;
        public DungeonControl(DungeonMap dungeon)
        {
            InitializeComponent();
            this.dungeon = dungeon;
            DrawDungeon();
            dungeon.OnUpdate += () => DrawDungeon();
        }

        public void DrawDungeon()
        {
            Controls.Clear();

            Point drawLocation = cardPanel.Location;
            var counter = 0;
            var maxItemHeight = 0;
            foreach (var room in dungeon.GetRooms())
            {
                RoomControl control = null;
                if (room is Card)
                    control = new CardControl((Card)room);
                if (room is PlayerObject)
                    control = new PlayerControl((PlayerObject)room);

                maxItemHeight = Math.Max(control.Height, maxItemHeight);
                control.Location = drawLocation;
                counter++;

                if (counter % dungeon.Height == 0)
                {
                    drawLocation = 
                        new Point(cardPanel.Location.X, drawLocation.Y + maxItemHeight);
                    counter = 0;
                }
                else
                {
                    drawLocation =
                        new Point(drawLocation.X + control.Width, drawLocation.Y);
                }

                control.Scale
                (new SizeF(0.75f,
                0.75f));

                if (dungeon.Selected != null)
                {

                    if (dungeon.Selected == room)
                    {
                        control.UseCustomBackColor = true;
                        control.BackColor = Color.Honeydew;
                    }

                    else if (dungeon.CanInteractInField(dungeon.Selected, room))
                    {
                        control.UseCustomBackColor = true;
                        control.BackColor = Color.BlueViolet;
                    }
                }

                else
                    control.UseCustomBackColor = false;

                Controls.Add(control);
            }

            daysLabel.Text = "Дней: " + dungeon.Game.Days;
        }
    }
}
