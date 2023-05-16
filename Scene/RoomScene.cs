using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MothersDayAdventureGame.Scene
{
    internal class RoomScene : Scene
    {
        public RoomScene(Game game) : base(game)
        {
            
        }

        public void Run()
        {
            string prompt = @$"{TextArt.RoomArt}";
            string[] options = { "Look in desk", "Look under bed", "Leave room" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    if (!MyGame.MyPlayer.HasFlashlight)
                    {
                        WriteLine("You find a flashlight in your desk and put it in your pocket.");
                        WriteLine("Maybe you could use it in a dark area.");
                        MyGame.MyPlayer.HasFlashlight = true;
                    }
                    else
                    {
                        WriteLine("There's nothing in here.");
                    };
                    ConsoleUtils.WaitForKeyPress();
                    Run();
                    break;
                case 1:
                    if (!MyGame.MyPlayer.HasMarble)
                    {
                        WriteLine("You look under your bed and find a shiny marble.");
                        WriteLine("It's so pretty that you take it just in case.");
                        MyGame.MyPlayer.HasMarble = true;
                    }
                    else
                    {
                        WriteLine("" +
                            "There's nothing under here.");
                    };
                    ConsoleUtils.WaitForKeyPress();
                    Run();
                    break;
                case 2:
                    MyGame.MyDenScene.Run();
                    break;
            }
        }
    }
}
