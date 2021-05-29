using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Cardville;
using Cardville.Engine;
using Cardville.Player;

namespace Cardville.Dungeon
{
    public class GameField
    {
        private readonly Game game;

        public event Update OnUpdate;
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

        public GameField (Game game, int width, int height)
        {
            this.game = game;
            gameField = new IInteractive[width, height];

            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    gameField[x, y] = game.Generator.GetRandomGroundObject();
                }
            }

            gameField[width / 2, height / 2] = game.Player;
        }

        private void Swap(Tuple<int,int> ind1, Tuple<int,int> ind2)
        {
            var t = gameField[ind1.Item1, ind1.Item2];
            gameField[ind1.Item1, ind1.Item2] = gameField[ind2.Item1, ind2.Item2];
            gameField[ind2.Item1, ind2.Item2] = t;
        }

        public void InteractInField(IInteractive a, IInteractive b)
        {
            var indexA = GetIndexers(a);
            //a position will be empty after that
            //b will be deleted and a moves to b
            var indexB = GetIndexers(b);
            
            var indexDelta =
                Tuple.Create(indexA.Item1 - indexB.Item1, indexA.Item2 - indexB.Item2);

            a.InteractWith(b);
            gameField[indexB.Item1, indexB.Item2]
                = gameField[indexA.Item1, indexA.Item2];

            var lastIndex = Tuple.Create(indexA.Item1, indexA.Item2);
            var nextIndex = Tuple.Create(lastIndex.Item1 + indexDelta.Item1, lastIndex.Item2 + indexDelta.Item2);

            while (nextIndex.Item1 >= 0 && nextIndex.Item1 < Width
                && nextIndex.Item2 >= 0 && nextIndex.Item2 < Height)
            {
                gameField[lastIndex.Item1, lastIndex.Item2]
                = gameField[nextIndex.Item1, nextIndex.Item2];

                lastIndex = nextIndex;
                nextIndex = Tuple.Create(lastIndex.Item1 - indexDelta.Item1, lastIndex.Item2 - indexDelta.Item2);
            }
            
            gameField[lastIndex.Item1, lastIndex.Item2] = game.Generator.GetRandomGroundObject();
            OnUpdate?.Invoke();
        }

        public bool CanInteractInField(IInteractive a, IInteractive b)
        {
            var indexA = GetIndexers(a);
            var indexB = GetIndexers(b);

            return (GetIndexers(a) != Tuple.Create(-1, -1))
                && (GetIndexers(b) != Tuple.Create(-1, -1))
                && (Math.Abs(indexA.Item1 - indexB.Item1)
                    + Math.Abs(indexA.Item2 - indexB.Item2) == 1)
                && a.CanInteractWith(b);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        private Tuple<int,int> GetIndexers (IInteractive interactive)
        {
            for (int x = 0; x < Width; ++x)
            {
                for (int y = 0; y < Height; ++y)
                {
                    if (gameField[x, y] == interactive)
                        return Tuple.Create(x, y);
                }
            }

            return Tuple.Create(-1, -1);
        }
    }
}
