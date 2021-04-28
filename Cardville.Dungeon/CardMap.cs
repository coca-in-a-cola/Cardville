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
                => new Size(cardField.GetLength(0), cardField.GetLength(1));
        }

        private readonly ICard[,] cardField;

        public ICard this[int indexX, int indexY]
        {
            get
                => cardField[indexX, indexY];
        }
    }
}
