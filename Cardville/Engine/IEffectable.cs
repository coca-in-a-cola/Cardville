using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Effects;

namespace Cardville.Engine
{
    public interface IEffectable
    {
        void ApplyEffect(Effect effect);
        bool CanApplyEffect(Effect effect);
        bool HasEffect(Effect effect);
        void RemoveEffect(Effect effect);
    }
}
