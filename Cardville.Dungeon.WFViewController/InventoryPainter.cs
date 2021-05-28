using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Cardville.Player;

namespace Cardville.Dungeon.WFViewController
{
    public class InventoryPainter : IPainter
    {
        private readonly Inventory inventory;
        public readonly List<GameObjectPainter> CanvasItems
            = new List<GameObjectPainter>();

        public Point Offset { get; set; }
        public Point Margin { get; set; }
        public int Columns { get; set; }

        private Control control = new Control();

        public InventoryPainter(Inventory inventory, int maxCol)
        {
            this.inventory = inventory;
            Offset = new Point(20, 20);
            Margin = new Point(10, 10);
            Columns = maxCol;
            Refresh();

            inventory.OnUpdate += () => Refresh();
        }

        private void ConstructControl()
        {
            CanvasItems.Clear();

            var drawLocation = Offset;
            var maxItemHeight = 0;
            var itemCounter = 0;
            foreach (var item in inventory.GetItems())
            {
                var control = PainterSelector.GetPainter(item.Key).GetControl();
                control.Location = drawLocation;
                

                if (item.Value)
                    control.BackColor = Color.FromArgb(144, 238, 144);

                this.control.Controls.Add(control);

                drawLocation.X += control.Width;
                drawLocation.X += Margin.X;

                maxItemHeight = Math.Max(maxItemHeight, control.Height);
                itemCounter++;

                if (itemCounter > Columns)
                {
                    itemCounter = 0;
                    drawLocation.X = Offset.X;
                    drawLocation.Y += maxItemHeight;
                    maxItemHeight = 0;
                }
            }
        }

        public void Refresh()
        {
            ConstructControl();
        }

        public Control GetControl()
            => control;
    }
}
