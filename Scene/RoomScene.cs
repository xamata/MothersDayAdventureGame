using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MothersDayAdventureGame.Scene
{
    internal class RoomScene : Scene
    {
        public RoomScene(Game game) : base(game)
        {
            
        }

        public void Run()
        {
            Console.WriteLine("Room Scene");
        }
    }
}
