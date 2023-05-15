using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MothersDayAdventureGame.Scene
{
    internal class ShedScene : Scene
    {
        public ShedScene(Game game):base(game)
        {
            
        }

        public void Run()
        {
            MyGame.MyPlayer.HasFlashlight = true;
            if (!MyGame.MyPlayer.HasFlashlight)
            {
                WriteLine("It's too dark to see in here. There's nothing to do...");
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyBackyardScene.Run();
            }
            else
            {
                string prompt = @$"Shed Scene...
Pick a color of paint to choose from.";
                string[] options = { "Red", "Green", "Blue", "Pink" };
                Menu menu = new Menu(prompt, options);
                int selectedIndex = menu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("You pick up the red paint and go back inside.");
                        MyGame.MyPlayer.PickUpPaint(ConsoleColor.DarkRed);
                        break;
                    case 1:
                        WriteLine("You pick up the green paint and go back inside.");
                        MyGame.MyPlayer.PickUpPaint(ConsoleColor.DarkGreen);
                        break;
                    case 2:
                        WriteLine("You pick up the blue paint and go back inside.");
                        MyGame.MyPlayer.PickUpPaint(ConsoleColor.DarkBlue);
                        break;
                    case 3:
                        WriteLine("You pick up the pink paint and go back inside.");
                        MyGame.MyPlayer.PickUpPaint(ConsoleColor.DarkMagenta);
                        break;
                }
            }
        }
    }
}
