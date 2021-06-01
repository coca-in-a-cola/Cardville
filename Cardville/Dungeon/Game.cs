using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using Cardville.Player;

namespace Cardville.Dungeon
{
    public class Game
    {
        public DungeonMap Map { get; }
        public int Days { get; private set; }
        public GamePhase Phase { get; private set; }
        public readonly PlayerObject Player;
        public readonly RarityTypeInfo RarityTypeInfo;
        public readonly GameData GameData;
        public readonly int Seed;

        private Action gameOver;
        public event Action OnGameOver
        {
            add { gameOver += value; }
            remove { gameOver -= value; }
        }

        public Game(string playerName)
        {
            Seed = new Random().Next();
            RarityTypeInfo = new RarityTypeInfo();
            GameData = new GameData();


            Player = new PlayerObject(this, playerName);
            Days = 1;

            Map = new DungeonMap(this, 3, 3);
        }

        public void NextDay()
        {
            ++Days;
        }

        public void GameOver ()
        {
            gameOver();
        }
    }
}
