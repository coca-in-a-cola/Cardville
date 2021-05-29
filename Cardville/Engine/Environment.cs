using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Cardville.Dungeon;

namespace Cardville.Engine
{
    public class Environment
    {
        public readonly Game Game;
        
        public Environment (Game game)
        {
            Game = game;
        }
        //Класс GameObject, который знает свой Environment
        //Game, Environment
    }
}
