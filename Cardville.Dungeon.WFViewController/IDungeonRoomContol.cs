using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;

namespace Cardville.Dungeon.WFViewController
{
    public interface IDungeonRoomContol
    {
        InteractiveGameObject GetGameObject();
    }
}
