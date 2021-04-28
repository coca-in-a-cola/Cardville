using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville
{
    public class RaritySystem
    {
        public enum Rarity
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

        public readonly IReadOnlyDictionary<Rarity, float> RarityPowerMultiplier = new Dictionary<Rarity, float>()
        {
            { Rarity.Common, 1f },
            { Rarity.Uncommon, 1.1f },
            { Rarity.Rare, 1.25f },
            { Rarity.Epic, 1.5f },
            { Rarity.Legendary, 1.75f },
            { Rarity.Mythical, 2.0f },
            { Rarity.Transcendent, 2.5f },
            { Rarity.Relict, 3f },
            { Rarity.Godly, 4.20f },
        };

        public readonly IReadOnlyDictionary<Rarity, float> RaritySpawnChance = new Dictionary<Rarity, float>() 
        {
            { Rarity.Common, 0.5f },
            { Rarity.Uncommon, 0.25f },
            { Rarity.Rare, 0.125f },
            { Rarity.Epic, 0.0625f },
            { Rarity.Legendary, 0.3125f },
            { Rarity.Mythical, 0.015625f },
            { Rarity.Transcendent, 0.0078125f },
            { Rarity.Relict, 0.00390625f },
            { Rarity.Godly, 0.001953125f },
        };

        public RaritySystem()
        {

        }

        public RaritySystem (
            Dictionary<Rarity, float> rarityPowerMultiplier,
            Dictionary<Rarity, float> raritySpawnChance )
            : this()
        {
            RarityPowerMultiplier = rarityPowerMultiplier;
            RaritySpawnChance = raritySpawnChance;
        }
    }
}