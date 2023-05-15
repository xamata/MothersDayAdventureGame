using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MothersDayAdventureGame.Scene
{
    internal class CreditScene : Scene
    {
        public CreditScene(Game game) : base(game) { }

        public void Run()
        {
            WriteLine("Run credit scene");
        }
    }
}
