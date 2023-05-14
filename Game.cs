using MothersDayAdventureGame.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MothersDayAdventureGame
{
    internal class Game
    {
        public TitleScene MyTitleScene;

        public Game()
        {
            MyTitleScene = new TitleScene(this);
        }
        public void Run()
        {
            MyTitleScene.Run();

            ConsoleUtils.WaitForKeyPress();
        }
    }
}
