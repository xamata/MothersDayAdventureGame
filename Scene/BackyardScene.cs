using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MothersDayAdventureGame.Scene
{
    internal class BackyardScene : Scene
    {
        public BackyardScene(Game game) : base(game) { }

        public void Run()
        {
            Console.WriteLine("Backyard Scene");
        }
    }
}
