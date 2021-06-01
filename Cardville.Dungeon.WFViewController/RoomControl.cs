using Cardville.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Dungeon.WFViewController
{
    public class RoomControl : MetroFramework.Controls.MetroUserControl, IDungeonRoomContol
    {
        public virtual InteractiveGameObject GetGameObject()
        {
            throw new NotImplementedException();
        }
    }
}
