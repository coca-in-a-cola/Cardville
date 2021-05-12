using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Cardville;

namespace Cardville.Dungeon
{
    public class CardMap
    {
        public Size Size 
        {
            get
                => new Size(gameField.GetLength(0), gameField.GetLength(1));
        }

        private readonly IInteractive[,] gameField;

        public IInteractive this[int indexX, int indexY]
        {
            get
                => gameField[indexX, indexY];
        }
    }
}
