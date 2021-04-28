using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Player
{
    public partial class Personality
    {
        public enum Class
        {
            None,
            Warrior,
            Wizard,
            Thief,
            Cleric,
        }

        public enum Gender
        {
            Male,
            Female,
        }

        public enum Race
        {
            Human,
            Elf,
            Hafling,
            Dwarf,
        }
    }
}
