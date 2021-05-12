using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville
{
    public interface IEffect
    {
        bool AppliesTo(IInteractive Target);
        IInteractive Target { get; set; }
    }
}
