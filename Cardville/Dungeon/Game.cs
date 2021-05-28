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
        public GameField Map { get; }
        public int Days { get; private set; }
        public GamePhase Phase { get; private set; }
        public readonly PlayerObject Player;
        public readonly Spawner Generator;
        public readonly RarityTypeInfo RarityTypeInfo;
        public readonly GameData GameData;
        public readonly int Seed;

        public IInteractive Selected { get; private set; }

        public event Update OnSelect;
        public event Update OnUnselect;
        public void Select(IInteractive interactive)
        {
            if (Selected == null)
            {
                Selected = interactive;
                OnSelect?.Invoke();
                return;
            }

            if (Selected.CanInteractWith(interactive))
            {
                if (Map.CanInteractInField(Selected, interactive))
                {
                    Map.InteractInField(Selected, interactive);
                    Unselect();
                }

                else
                {
                    Selected.InteractWith(interactive);
                    Unselect();
                }
            }

            else
                Unselect();
        }

        public void Unselect()
        {
            Selected = null;
            OnUnselect?.Invoke();
        }

        public Game(string playerName)
        {
            Seed = new Random().Next();
            Player = new PlayerObject(this, playerName);
            RarityTypeInfo = new RarityTypeInfo();
            Generator = new Spawner(this);

            GameData = new GameData();

            Map = new GameField(this, 3, 3);
        }
    }
}
