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
        public readonly List<Change> Changes;

        public Effect (params Change [] changes)
        {
            Changes = changes.ToList();
        }

        public override int GetHashCode()
        {
            var result = 0x1337;
            foreach (var c in Changes)
            {
                unchecked
                {
                    result *= 0x420;
                    result += c.GetHashCode();
                }
            }

            return unchecked(result);
        }
    }
}