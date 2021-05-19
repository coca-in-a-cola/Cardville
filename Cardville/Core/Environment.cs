using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Cardville.Core
{
    public class Environment
    {
        public readonly Table3D<Type, RarityType, PropertyInfo, float> TypeRarityPropertyValues
            = new Table3D<Type, RarityType, PropertyInfo, float>();

        public void SetValue
            (Type type, RarityType rarity, PropertyInfo property, float value)
        {
            TypeRarityPropertyValues[type, rarity, property] = value;
        }

        public double GetValue
            (Type type, RarityType rarity, PropertyInfo property)
            => TypeRarityPropertyValues[type, rarity, property];
    }
}
