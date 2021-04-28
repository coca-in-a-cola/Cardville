using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cardville.Dungeon
{
    class Sprite : Node
    {
        private readonly Bitmap pixels;
        private Graphics graphics;

        public void Draw()
        {
            throw new NotImplementedException();
        }
        //Анимации как фоновые задачи
        public new void Update(float deltaDime) //время с предыдущего кадра
        {
            throw new NotImplementedException();
        }
    }
}
