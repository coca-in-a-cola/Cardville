using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;
using Cardville.Player;
using Cardville.Cards;

namespace Cardville.Dungeon.WFViewController
{
    public static class PainterSelector
    {
        public static GameObjectPainter GetPainter(IInteractive gameObject)
        {
            switch (gameObject)
            {
                case PlayerObject playerObject:
                    return new PlayerPainter(playerObject);
                case Card card:
                    return new CardPainter(card);
                default:
                    return new GameObjectPainter(gameObject);
            }
        }
    }
}
