using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville
{
    public interface IEffect
    {
        bool AppliesTo(ICard Target);
        ICard Target { get; set; }
        Action Apply { get; set; }
        Action Remove { get; set; }
    }
}
