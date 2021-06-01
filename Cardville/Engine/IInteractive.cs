using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Engine
{
    public interface IInteractive
    {
        bool CanInteractWith(IInteractive another);
        void InteractWith(IInteractive another);
    }
}
