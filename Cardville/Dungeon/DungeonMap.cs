using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Engine;

namespace Cardville.Dungeon
{
    public class DungeonMap : GameObject
    {
        private List<InteractiveGameObject> rooms;
        private Spawner spawner;

        public InteractiveGameObject Selected { get; private set; }
        private int selectedIndex = -1;


        public readonly int Width;
        public readonly int Height;

        private readonly int xStep;
        private readonly int yStep;

        public DungeonMap(Game game, int width, int height) : base(game, "Dungeon", GameObjectType.Empty)
        {
            Width = width;
            Height = height;
            xStep = 1;
            yStep = width;
            rooms = new List<InteractiveGameObject>(width * height);

            spawner = new Spawner(game);
            for (int i = 0; i < Width * Height; ++i)
            {
                rooms.Add(spawner.GetRandomGroundObject());
            }

            rooms[(Width / 2) * xStep + (Height / 2) * yStep] = game.Player;

            UpdateSelf();
        }

        private bool IsInBounds(int index)
            => index >= 0 && index < (Width * Height);

        private void InteractInField(InteractiveGameObject initiator, InteractiveGameObject target)
        {
            int index = rooms.IndexOf(initiator);
            var targetIndex = rooms.IndexOf(target);

            var delta = targetIndex - index;
            var lastIndex = -1;
            for (int i = targetIndex; IsInBounds(i); i -= delta)
            {
                if (IsInBounds(i - delta))
                    rooms[i] = rooms[i - delta];
                else
                    lastIndex = i;
            }

            rooms[lastIndex] = spawner.GetRandomGroundObject();
            initiator.InteractWith(target);
            initiator.UpdateSelf();
            target.UpdateSelf();

            UpdateSelf();
        }

        public bool CanInteractInField(InteractiveGameObject initiator, InteractiveGameObject target)
        {
            if (!initiator.CanInteractWith(target))
                return false;

            int index = rooms.IndexOf(initiator);
            if (index == -1)
                return false;

            var targetIndex = rooms.IndexOf(target);
            if (targetIndex == -1)
                return false;

            if (Math.Abs(index - targetIndex) == xStep
                || Math.Abs(index - targetIndex) == yStep)
                return true;

            return false;
        }

        private IEnumerable<InteractiveGameObject> GetNearbyObjects
            (int index)
        {
            var dx = new [] { 0, 1, 0, -1};
            var dy = new[] { 1, 0, -1, 0 };

            for (int i = 0; i < 4; ++i)
            {
                var targetIndex = index + dx[i] * xStep + dy[i] * yStep;
                if (IsInBounds(targetIndex))
                {
                    yield return rooms[targetIndex];
                }
            }
        }

        public IEnumerable<InteractiveGameObject> GetNearbyObjects
            (InteractiveGameObject target)
        {
            int index = rooms.IndexOf(target);
            if (index == -1)
                yield break;

            foreach (var e in GetNearbyObjects(index))
                yield return e;
        }

        public bool SelectItem(InteractiveGameObject selected)
        {
            if (selected == Selected)
                return false;

            var index = rooms.IndexOf(selected);

            if (index == -1)
                return false;

            if (selectedIndex == -1)
            {
                Selected = selected;
                selectedIndex = index;
                Selected.UpdateSelf();
                UpdateSelf();
                return true;
            }

            if (CanInteractInField(Selected, selected))
            {
                InteractInField(Selected, selected);
                Selected = null;
                selectedIndex = -1;
                return true;
            }

            Selected = null;
            selectedIndex = -1;
            return false;
        }

        public IEnumerable<InteractiveGameObject> GetRooms()
        {
            for (int i = 0; i < Width * Height; ++i)
                yield return rooms[i];
        }
    }
}
