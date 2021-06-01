using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Cardville.Player;
using Cardville.Cards;

namespace Cardville.Dungeon.WFViewController
{
    public class DungeonPainter : IPainter
    {
        public readonly Game Game;

        public readonly List<GameObjectPainter> CanvasItems
            = new List<GameObjectPainter>();

        public Color SelectedColor = Color.LightGreen;
        public Color SelectableColor = Color.LightCyan;
        public Color NormalColor = Color.FromArgb(250, 204, 152);

        public Point Offset { get; set; }
        public Point Margin { get; set; }

        private Control control = new Control();

        public DungeonPainter(Game game)
        {
            Game = game;
            Offset = new Point(20, 20);
            Margin = new Point(10, 10);
            Refresh();
            Game.Map.OnUpdate += () => Refresh();
        }

        public void HighlightForSelected()
        {
            foreach (var e in CanvasItems)
            {
               // else if (Game.Map.CanInteractInField(Game.Selected, e.GetIInteractive()))
                   // e.GetControl().BackColor = SelectableColor;
            }
        }

        public void Unselect()
        {
            foreach (var e in CanvasItems)
            {
                e.GetControl().BackColor = NormalColor;
            }
        }

        private void RebuildInteractiveControls()
        {
            CanvasItems.Clear();

            for (int xIndex = 0; xIndex < Game.Map.Width; ++xIndex)
            {
                for (int yIndex = 0; yIndex < Game.Map.Height; ++yIndex)
                {
                    //var gameObject = Game.Map[xIndex, yIndex];
                    //CanvasItems.Add(PainterSelector.GetPainter(gameObject));
                }
            }
        }

        private void ConstructControl()
        {
            var drawLocation = Offset;
            for (int yIndex = 0; yIndex < Game.Map.Height; ++yIndex)
            {
                var maxItemHeight = 0;
                for (int xIndex = 0; xIndex < Game.Map.Width; ++xIndex)
                {
                    var index = xIndex + yIndex * Game.Map.Width;
                    var control = CanvasItems[index].GetControl();
                    control.Location = drawLocation;

                   // control.Click += (sender, args)
                        //=> Game.Select(CanvasItems[index].GetIInteractive());

                    this.control.Controls.Add(control);

                    drawLocation.X += control.Width;
                    drawLocation.X += Margin.X;

                    maxItemHeight = Math.Max(maxItemHeight, control.Height);
                }

                drawLocation.Y += maxItemHeight;
                drawLocation.Y += Margin.Y;
                drawLocation.X = Offset.X;
            }
        }

        public void Refresh()
        {
            RebuildInteractiveControls();
            ConstructControl();
        }

        public Control GetControl()
            => control;
    }
}
