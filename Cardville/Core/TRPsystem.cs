using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Cardville.Core
{
    public class TRPsystem
    {
        private readonly Table3D<Type, RarityType, PropertyInfo, double> dData = new Table3D<Type, RarityType, PropertyInfo, double>();
        private readonly Table3D<Type, RarityType, PropertyInfo, int> iData;

        public void AddValue (Type type, RarityType rarity, PropertyInfo property, double value)
        {
            dData[type, rarity, property] = value;
        }

        public void AddValue(Type type, RarityType rarity, PropertyInfo property, int value)
        {
            iData[type, rarity, property] = value;
        }

        public double GetValue(Type type, RarityType rarity, PropertyInfo property)
            => dData[type, rarity, property];

        public int SetValue(Type type, RarityType rarity, PropertyInfo property, int value)
            => iData[type, rarity, property] = value;
    }
}
