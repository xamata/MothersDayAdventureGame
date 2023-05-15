﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MothersDayAdventureGame.Scene
{
    internal class FrontyardScene : Scene
    {
        private bool GnomeHasMarble;
        public FrontyardScene(Game game) : base(game)
        {
            GnomeHasMarble = false;
        }

        public void Run()
        {
            MyGame.MyPlayer.HasMarble = true;
            string prompt = @$"Frontyard SCENE";
            string[] options = { "Go into garden","Distract garden gnome", "Go back inside" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    if (GnomeHasMarble) 
                    { 
                        DisplayGarden();
                    }
                    else { 
                        WriteLine("That garden gnome is protecting his garden.");
                        WriteLine("Find something to distract him.");
                    };
                    ConsoleUtils.WaitForKeyPress();
                    Run();
                    break;
                case 1:
                    if (GnomeHasMarble)
                    {
                        WriteLine("The gnome is distracted by a shiny object.");
                    }
                    else if (MyGame.MyPlayer.HasMarble)
                    {
                        WriteLine("You place your shiny marble next to the gnome.");
                        WriteLine("The gnome can't help but to stare at it.");
                        GnomeHasMarble = true;
                    }
                    else {
                        WriteLine("You have nothing to distract the gnome..."); 
                    }
                    ConsoleUtils.WaitForKeyPress();
                    Run();
                    break;
                case 2:
                    MyGame.MyDenScene.Run();
                    break;

            }
        }

        private void DisplayGarden()
        {
            if (MyGame.MyPlayer.HasFlowers) { WriteLine("has flowers"); } else { WriteLine("Doesn't have flowers"); }
            WriteLine("===Display Garden===");
            WriteLine("You pick the prettiest flowers you can find. Good thing mom has tons of them!");
            MyGame.MyPlayer.HasFlowers = true;
            if (MyGame.MyPlayer.HasFlowers) { WriteLine("has flowers"); } else { WriteLine("Doesn't have flowers"); }
        }
    }
}
