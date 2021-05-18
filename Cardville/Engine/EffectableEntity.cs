using Cardville.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Engine
{
    public abstract class EffectableEntity : Entity, IEffectable
    {
        private HashSet<Effect> activeEffectsSet = new HashSet<Effect>();
        private Stack<Effect> activeEffects = new Stack<Effect>();
        private Dictionary<string, object> originalValues;

        public EffectableEntity(string name, int level) : base(name, level)
        {

        }

        public virtual bool CanApplyEffect(Effect effect)
        {
            foreach (var change in effect.Changes)
            {
                if (GetType().GetProperty(change.TargetValue) == null)
                    return false;
            }

            return true;
        }

        public virtual void ApplyEffect(Effect effect)
        {
            foreach (var change in effect.Changes)
            {
                var propertyAffected = GetType().GetProperty(change.TargetValue);

                var propertyValue = propertyAffected.GetValue(this);

                if (!originalValues.ContainsKey(change.TargetValue))
                    originalValues[change.TargetValue] = propertyValue;

                propertyAffected.SetValue(this,
                    change.Formula(propertyValue));
            }

            activeEffectsSet.Add(effect);
            activeEffects.Push(effect);
        }

        public virtual void RemoveEffect(Effect effect)
        {
            var firstFound = false; 
            var copyWithoutEffect = activeEffects.Where (
                e =>
                {
                    if (e == effect && !firstFound)
                    {
                        firstFound = true;
                        return false;
                    }
                    return true;
                }
            );

            RestoreOriginalValues();

            activeEffects.Clear();
            activeEffectsSet.Clear();

            foreach (var e in copyWithoutEffect.Reverse())
            {
                ApplyEffect(e);
            }
        }

        private void RestoreOriginalValues()
        {
            foreach (var valueName in originalValues.Keys)
                GetType()
                .GetProperty(valueName)
                .SetValue(this, originalValues[valueName]);

            originalValues.Clear();
        }

        public bool HasEffect(Effect effect)
            => activeEffectsSet.Contains(effect);
    }
}
