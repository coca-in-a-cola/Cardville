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
    public class Spawner : GameObject
    {
        private CDFGenerator<Tuple<GameObjectType, Rarity>> typeRarityGenerator;
        private CDFGenerator<Rarity> rarityGenerator;
        private Random random;

        public Spawner (Game game) : base(game, "spawner", GameObjectType.Empty)
        {
            random = new Random(game.Seed);
            var spawnWeights = new List<KeyValuePair<Tuple<GameObjectType, Rarity>, double>>();

            foreach (var type in
                Enum.GetValues(typeof(GameObjectType)).Cast<GameObjectType>())
            {
                foreach (var rarity in
                Enum.GetValues(typeof(Rarity)).Cast<Rarity>())
                {
                    var value = Game.RarityTypeInfo.GetSpawnChanceWeight(type, rarity);
                    spawnWeights.Add(new KeyValuePair<Tuple<GameObjectType, Rarity>, double>
                        (Tuple.Create(type, rarity), value));
                }
            }

            var raritySpawnWeights = new List<KeyValuePair<Rarity, double>>();

            foreach (var rarity in
                Enum.GetValues(typeof(Rarity)).Cast<Rarity>())
            {
                var value = Game.RarityTypeInfo.GetSpawnChanceWeight(GameObjectType.Equipment, rarity);
                raritySpawnWeights.Add(new KeyValuePair<Rarity, double>
                    (rarity, value));
            }

            typeRarityGenerator = new CDFGenerator<Tuple<GameObjectType, Rarity>>
                (spawnWeights, random.Next());

            rarityGenerator = new CDFGenerator<Rarity>(raritySpawnWeights, random.Next());

            UpdateSelf();
        }

        public InteractiveGameObject GetRandomGroundObject()
        {
            var typeRarity = typeRarityGenerator.SpawnFromTable();
            var SelectedList = Game
                .GameData
                .CardTemplatesOfType[typeRarity.Item1]
                .Where(e => e.Rarity == typeRarity.Item2)
                .ToList();

            var randomIndex = random.Next(SelectedList.Count);

            var template = SelectedList[randomIndex];
            var level = (int)Math.Round
                (Math.Pow(Game.Days, 0.2) * Game.Player.Level
                + 1);

            UpdateSelf();
            return Card.FromTemplate(Game, template, level);
        }

        public InteractiveGameObject GetRandomObjectOfType(GameObjectType type)
        {
            var rarity = rarityGenerator.SpawnFromTable();
            var SelectedList = Game
                .GameData
                .CardTemplatesOfType[type]
                .Where(e => e.Rarity == rarity)
                .ToList();

            var randomIndex = random.Next(SelectedList.Count);

            var template = SelectedList[randomIndex];

            var level = (int)Math.Round
                (Math.Pow(Game.Days == 0 ? 1 : Game.Days, 0.2)
                * (Game.Player == null ? 1 : Game.Player.Level)
                + 1);

            UpdateSelf();
            return Card.FromTemplate(Game, template, level);
        }
    }
}
