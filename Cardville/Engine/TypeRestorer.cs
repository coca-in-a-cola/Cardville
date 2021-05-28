using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Player;
using Cardville.Cards;
using Cardville.Dungeon;

namespace Cardville.Engine
{
    public static class TypeRestorer
    {
        public static GameObjectType GetGameObjectType(IInteractive interactive)
        {
            switch (interactive)
            {
                case PlayerObject playerObject:
                    return GameObjectType.Player;
                case Card card:
                    return card.Type;
                default:
                    return GameObjectType.Empty;
            }
        }
    }
}
