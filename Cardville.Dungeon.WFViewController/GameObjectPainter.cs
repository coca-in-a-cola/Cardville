using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cardville.Engine;
using System.Drawing;

namespace Cardville.Dungeon.WFViewController
{
    public class GameObjectPainter : IPainter, IHasIInteractive
    {
        protected readonly Control control;
        protected readonly IInteractive gameObject;

        public GameObjectPainter(IInteractive gameObject)
        {
            control = new Button();
            GameObjectType type = TypeRestorer.GetGameObjectType(gameObject);

            // Style    
            control.BackColor = Color.FromArgb(250, 204, 152);
            //control.ForeColor = Color.FromArgb(250, 204, 152);
            control.Height = 300;
            control.Width = 200;
            // end style

            var typeLabel = TypeLabels.From(type);
            typeLabel.BackColor = Color.Transparent;
            control.Controls.Add(typeLabel);
            typeLabel.Width = control.Width / 2;
            typeLabel.Height = control.Height / 6;
            typeLabel.Location = new Point(
                control.Width
                - typeLabel.Width
                - control.Width / 20,
                control.Height - typeLabel.Height);

            this.gameObject = gameObject;
        }

        public virtual Control GetControl()
            => control;

        public virtual IInteractive GetIInteractive()
            => gameObject;
    }
}
