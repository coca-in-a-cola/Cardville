using NUnit.Framework;
using Cardville.Engine;
using Cardville.Dungeon;
using System.Linq;

namespace TestProject
{
    public class DungeonFieldTests
    {
        private Game testGame;
        private DungeonMap dungeon
            => testGame.Map;

        [SetUp]
        public void Setup()
        {
            testGame = new Game("tester");
        }

        [Test]
        public void SelectsPlayer()
        {
            dungeon.SelectItem(testGame.Player);
            Assert.AreEqual(testGame.Player, dungeon.Selected);
        }

        [Test]
        public void HasGeneratedMap()
        {
            var lastRoom = dungeon.GetRooms().FirstOrDefault();
            foreach (var room in dungeon.GetRooms().Skip(1))
            {
                if (room != lastRoom && room != null)
                    continue;

                Assert.Fail();
            }

            Assert.Pass();
        }

        [Test]
        public void RemovesSelectionIfNoInteract()
        {
            var rooms = dungeon.GetRooms().ToList();
            dungeon.SelectItem(rooms[0]);
            dungeon.SelectItem(rooms[1]);
            Assert.AreEqual(null, dungeon.Selected);
        }

        [Test]
        public void CantSelectUnexistingItem()
        {
            var parallelGame = new Game("tester2");
            var rooms = dungeon.GetRooms();
            var parallelRooms = parallelGame.Map.GetRooms();
            dungeon.SelectItem(parallelRooms.FirstOrDefault());
            Assert.AreEqual(null, dungeon.Selected);
        }

        [Test]
        public void CantSelectIfNotNeighbours()
        {
            var rooms = dungeon.GetRooms();
            var near = dungeon.GetNearbyObjects(testGame.Player);

            var far = rooms.Where((e) => !near.Contains(e) && e != testGame.Player);

            dungeon.SelectItem(testGame.Player);
            foreach (var room in far)
            {
                dungeon.SelectItem(room);
                Assert.AreEqual(null, dungeon.Selected);

                dungeon.SelectItem(testGame.Player);
            }
        }

        [Test]
        public void ChangePositionAfterInteract()
        {
            var near = dungeon.GetNearbyObjects(testGame.Player);

            dungeon.SelectItem(testGame.Player);
            var target = near.FirstOrDefault();
            
            dungeon.SelectItem(target);

            Assert.AreEqual(null, dungeon.Selected);

            var rooms = dungeon.GetRooms();
            Assert.AreEqual(false, rooms.Contains(target));

            int intiatorCount = 0;
            foreach (var room in rooms)
            {
                if (room == testGame.Player)
                    if (intiatorCount == 0)
                        intiatorCount++;
                    else
                        Assert.Fail();
            }

            Assert.Pass();
        }
    }
}