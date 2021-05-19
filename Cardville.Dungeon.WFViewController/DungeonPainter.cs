using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cardville.Dungeon.WFViewController
{
    public class DungeonPainter : IHasControl
    {
        public readonly Game Game;
        public readonly GameLevelForm Form;

        public readonly List<IneractiveControl> IneractiveControls
            = new List<IneractiveControl>();

        public Point Offset { get; set; }
        public Point GridSize { get; set; }
        public Point GridMargin { get; set; }

        private Control control = new Control();

        public DungeonPainter(Game game, GameLevelForm form)
        {
            Game = game;
            Form = form;

            var vw = Form.Width / Game.Map.Width;
            var vh = Form.Height / Game.Map.Height;

            Offset = new Point(0, 0);
            GridSize = new Point(vw - vw / 10, vh - vh / 10);
            GridMargin = new Point(vw / 10, vh / 10);

            Refresh();
        }

        private void RebuildInteractiveControls()
        {
            IneractiveControls.Clear();

            for (int xIndex = 0; xIndex < Game.Map.Width; ++xIndex)
            {
                for (int yIndex = 0; yIndex < Game.Map.Height; ++yIndex)
                {
                    IneractiveControls.Add(new IneractiveControl(Game.Map[xIndex, yIndex]));
                }
            }
        }

        private void ConstructControl()
        {
            var drawLocation = Offset;
            for (int cotrolIndex = 0; cotrolIndex < IneractiveControls.Count; ++cotrolIndex)
            {
                var interactiveControl = IneractiveControls[cotrolIndex];
                interactiveControl.GetControl().Location = drawLocation;
                control.Controls.Add(interactiveControl.GetControl());

                //Make Rows
                if (cotrolIndex % Game.Map.Width == 0 && cotrolIndex != 0)
                {
                    drawLocation.Y += GridSize.Y + GridMargin.Y;
                    drawLocation.X = 0;
                }

                else
                    drawLocation.X += GridSize.X + GridMargin.X;
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
