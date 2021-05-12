using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Cards;
using System.Linq.Expressions;

namespace Cardville.Effects
{
    public class Effect
    {
        public readonly Expression<Action<Card>> Formula;
        private Action<Card> action;

        public delegate void EffectEventHandler(object sender, EventArgs e);
        public event EffectEventHandler OnApply;

        public Effect(Expression<Action<Card>> formula)
        {
            action = formula.Compile();
        }

        public void Apply(Card to)
        {
            lock (to)
            {
                action(to);
            }

            OnApply?.Invoke(this, new EventArgs());
        }
    }
}
