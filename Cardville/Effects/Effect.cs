using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Effects
{
    class Effect : IEffect
    {
        public ICard Target { get => throw new NotImplementedException();}
        public bool AppliesTo(ICard target)
        {
            throw new NotImplementedException();
        }
        public void Apply()
    }
}
