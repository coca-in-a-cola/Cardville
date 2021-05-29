using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Core
{
    public class CDFGenerator<TItem>
    {
        private readonly List<KeyValuePair<TItem, double>> spawnTable;
        private Random random;
        public CDFGenerator(List<KeyValuePair<TItem, double>> spawnWeights, int seed)
        {
            spawnTable = MakeSpawnTableFromWeights(spawnWeights);
            random = new Random(seed);
        }

        private List<KeyValuePair<TItem, double>> MakeSpawnTableFromWeights
            (List<KeyValuePair<TItem, double>> spawnWeights)
        {
            var sum = spawnWeights.Select(keyValue => keyValue.Value).Sum();

            return spawnWeights.Select(keyValue
                => new KeyValuePair<TItem, double>(keyValue.Key, keyValue.Value / sum))
                .ToList();
        }
        /// <summary> Cumilative Destribution Function
        /// <para>spawning items based on their probability</para>
        /// </summary>
        /// <param name="spawnTable">
        /// each element is a keyvalue pair,
        /// with the key being the element itself
        /// and the value being the probability of that element (between 0.0 and 1.0)
        /// </param>
        public TItem SpawnFromTable()
        {
            double diceRoll = random.NextDouble();
            random = new Random(random.Next());
            double cumulative = 0.0;
            for (int i = 0; i < spawnTable.Count; i++)
            {
                cumulative += spawnTable[i].Value;
                if (diceRoll < cumulative)
                {
                    return spawnTable[i].Key;
                }
            }

            //If we didn't return anything before,
            //it means that sum of all our chances in spawntable is less than 1
            throw new ArgumentException();
        }
    }
}
