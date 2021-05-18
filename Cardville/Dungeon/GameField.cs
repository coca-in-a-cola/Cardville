using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Cardville;
using Cardville.Engine;

namespace Cardville.Dungeon
{
    public class GameField
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        private readonly IInteractive[,] gameField;

        public IInteractive this[int indexX, int indexY]
        {
            get
                => gameField[indexX, indexY];
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
