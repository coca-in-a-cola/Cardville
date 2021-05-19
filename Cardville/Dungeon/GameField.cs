using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Cardville;
using Cardville.Engine;
//REmove
using Cardville.Cards;

namespace Cardville.Dungeon
{
    public class GameField
    {
        public int Width
        {
            get
                => gameField.GetLength(0);
        }
        public int Height
        {
            get
                => gameField.GetLength(1);
        }

        private readonly IInteractive[,] gameField;

        public IInteractive this[int indexX, int indexY]
        {
            get
                => gameField[indexX, indexY];
        }

        public GameField (int width, int height)
        {
            gameField = new IInteractive[width, height];

            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    //TODO: удалить это!
                    gameField[x, y] = new Monster(new CardTemplate(), 1);
                }
            }
                
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
