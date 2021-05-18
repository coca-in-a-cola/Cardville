using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;

namespace Cardville.Effects
{
    public class State
    {
        private readonly IEffectable Effectable;
        private Stack<Effect> effects;

        public State (IEffectable effectable)
        {
            Effectable = effectable;
        }
    }
}
