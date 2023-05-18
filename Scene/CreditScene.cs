using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
            string prompt = @"Thanks for playing Mom's Gift Adventure Game. I hope you found it endlessly enjoyable!

=== Credits ===
> ASCIIFlow, http://asciiflow.com/
> Figgle, https://github.com/drewnoakes/figgle
> ASCIIartclub, https://asciiart.club/
> ASCII Art Archive, https://www.asciiart.eu/


Would you like to play again?";
            string[] options = { "Yes", "No" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();
            switch (selectedIndex)
            {
                case 0:
                    // Restarts the game
                    // Quick fix on restart
                    MyGame.MyFrontyardScene.GnomeHasMarble = false;
                    MyGame.MyPlayer.ResetItems();
                    MyGame.Start();
                    return;
                case 1:
                    ConsoleUtils.QuitConsole();
                    break;
            }
        }
    }
 }
