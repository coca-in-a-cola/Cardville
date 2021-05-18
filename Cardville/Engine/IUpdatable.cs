using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Engine
{
    public delegate void UpdateEventHandler(object sender, EventArgs e);

    public interface IUpdatable
    {
        void Update();
    }
}
