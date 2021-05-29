using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Cards;

namespace Cardville.Engine
{
    public class RarityTypeInfo
    {
        private readonly List<float> rarityPowerMultiplier = new List<float>()
            {1f, 1.1f, 1.25f, 1.5f, 1.75f, 2.0f, 2.5f, 3f, 4.20f};

        private readonly List<float> typePowerMultiplier = new List<float>()
            {0f, 1f, 1f, 0.8f, 0.5f, 0.4f, 0.2f};

        //Than more is weight, than greater is the chance
        private readonly List<float> raritySpawnChanceWeights = new List<float>()
            {256, 128, 64, 32, 16, 8 , 4, 2, 1};

        private readonly List<float> typeSpawnChanceWeights = new List<float>()
            {0, 0, 12, 0, 0, 0, 4,};

        public float GetPowerMultiplier(GameObjectType type, Rarity rarity)
            => typePowerMultiplier[(int)(type)] * rarityPowerMultiplier[(int)(rarity)];

        public float GetSpawnChanceWeight(GameObjectType type, Rarity rarity)
            => typeSpawnChanceWeights[(int)(type)] * raritySpawnChanceWeights[(int)(rarity)];
    }
}
