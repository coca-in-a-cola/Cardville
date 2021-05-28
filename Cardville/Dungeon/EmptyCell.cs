using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;

namespace Cardville.Dungeon
{
    public class EmptyCell : GameObject
    {
        public EmptyCell(Game game, string name, GameObjectType type) : base(game, name, type)
        {
        }
    }
}
