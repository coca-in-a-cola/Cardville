using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Effects
{
    public class Change
    {
        public readonly string TargetValue;
        public readonly Func<object, object> Formula;

        public Change (string targetValue, Func<object, object> formula)
        {
            TargetValue = targetValue;
            Formula = formula;
        }
        public override int GetHashCode()
        {
            return unchecked((TargetValue.GetHashCode() * 0x228 + Formula.GetHashCode())
                ^ TargetValue.GetHashCode());
        }
    }
}
