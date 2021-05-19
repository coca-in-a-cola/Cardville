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
    public class IneractiveControl : IHasControl, IHasIInteractive
    {
        public readonly Control Control;
        public readonly IInteractive GameObject;

        public IneractiveControl(IInteractive gameObject)
        {
            Control = new GroupBox();

            // Style
            Control.BackColor = Color.Blue;
            // end style

            GameObject = gameObject;
        }

        public virtual Control GetControl()
            => Control;

        public virtual IInteractive GetIInteractive()
            => GameObject;
    }
}
