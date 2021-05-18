using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Core
{
    public enum RarityType
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Mythical,
        Transcendent,
        Relict,
        Godly
    }

    public class RaritySystem
    {
        

        public readonly IReadOnlyDictionary<RarityType, float> RarityPowerMultiplier = new Dictionary<RarityType, float>()
        {
            { RarityType.Common, 1f },
            { RarityType.Uncommon, 1.1f },
            { RarityType.Rare, 1.25f },
            { RarityType.Epic, 1.5f },
            { RarityType.Legendary, 1.75f },
            { RarityType.Mythical, 2.0f },
            { RarityType.Transcendent, 2.5f },
            { RarityType.Relict, 3f },
            { RarityType.Godly, 4.20f },
        };

        public readonly IReadOnlyDictionary<RarityType, float> RaritySpawnChance = new Dictionary<RarityType, float>() 
        {
            { RarityType.Common, 0.5f },
            { RarityType.Uncommon, 0.25f },
            { RarityType.Rare, 0.125f },
            { RarityType.Epic, 0.0625f },
            { RarityType.Legendary, 0.3125f },
            { RarityType.Mythical, 0.015625f },
            { RarityType.Transcendent, 0.0078125f },
            { RarityType.Relict, 0.00390625f },
            { RarityType.Godly, 0.001953125f },
        };

        public RaritySystem()
        {

        }

        public RaritySystem (
            Dictionary<RarityType, float> rarityPowerMultiplier,
            Dictionary<RarityType, float> raritySpawnChance )
            : this()
        {
            RarityPowerMultiplier = rarityPowerMultiplier;
            RaritySpawnChance = raritySpawnChance;
        }
    }
}