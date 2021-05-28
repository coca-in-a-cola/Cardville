using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using Cardville.Cards;
using Cardville.Core;

namespace Cardville.Dungeon
{
    public class Spawner
    {
        public readonly Game RelatedGame;
        private CDFGenerator<Tuple<GameObjectType, Rarity>> typeRarityGenerator;
        private Random random;

        public Spawner (Game game)
        {
            RelatedGame = game;
            random = new Random(game.Seed);
            var spawnWeights = new List<KeyValuePair<Tuple<GameObjectType, Rarity>, double>>();

            foreach (var type in
                Enum.GetValues(typeof(GameObjectType)).Cast<GameObjectType>())
            {
                foreach (var rarity in
                Enum.GetValues(typeof(Rarity)).Cast<Rarity>())
                {
                    var value = RelatedGame.RarityTypeInfo.GetSpawnChanceWeight(type, rarity);
                    spawnWeights.Add(new KeyValuePair<Tuple<GameObjectType, Rarity>, double>
                        (Tuple.Create(type, rarity), value));
                }
            }

            var randomSeed = random.Next();
            typeRarityGenerator = new CDFGenerator<Tuple<GameObjectType, Rarity>>
                (spawnWeights, randomSeed);
        }

        public IInteractive GetRandomGroundObject()
        {
            var typeRarity = typeRarityGenerator.SpawnFromTable();
            var SelectedList = RelatedGame
                .GameData
                .CardTemplatesOfType[typeRarity.Item1]
                .Where(e => e.Rarity == typeRarity.Item2)
                .ToList();

            var randomIndex = random.Next(SelectedList.Count);

            var randomCoef = (random.NextDouble() * 2 - 1) * 0.13;
            var template = SelectedList[randomIndex];
            var level = (int)Math
                .Sqrt(RelatedGame.Days
                * RelatedGame.Player.Level
                * RelatedGame.Player.Level
                * randomCoef
                + 3);

            return Card.FromTemplate(RelatedGame, template, level);
        }
    }
}
