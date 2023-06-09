﻿using System;
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
            if (!MyGame.MyPlayer.HasFlashlight)
            {
                WriteLine("It's too dark to see in here. There's nothing to do...");
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyBackyardScene.Run();
            }
            else
            {
                string prompt = @$"Shed Scene...
Pick a color of dye to choose from.";
                string[] options = { "Red", "Green", "Blue", "Pink" };
                Menu menu = new Menu(prompt, options);
                int selectedIndex = menu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("You pick up the red dye and go back inside.");
                        MyGame.MyPlayer.PickUpDye(ConsoleColor.DarkRed);
                        break;
                    case 1:
                        WriteLine("You pick up the green dye and go back inside.");
                        MyGame.MyPlayer.PickUpDye(ConsoleColor.DarkGreen);
                        break;
                    case 2:
                        WriteLine("You pick up the blue dye and go back inside.");
                        MyGame.MyPlayer.PickUpDye(ConsoleColor.DarkBlue);
                        break;
                    case 3:
                        WriteLine("You pick up the pink dye and go back inside.");
                        MyGame.MyPlayer.PickUpDye(ConsoleColor.DarkMagenta);
                        break;
                }
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyDenScene.Run();
            }
        }
    }
}
