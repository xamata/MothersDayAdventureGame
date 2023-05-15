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
            string prompt = @"Thanks for playing Mom's Gift Adventure Game. I hope you found it endlessly enjoyable.

=== Credits ===
> ASCIIFlow, http://asciiflow.com/
> TAAG, http://patorjk.com/software/taag/

Would you like to play again?";
            string[] options = { "Yes", "No" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();
            switch (selectedIndex)
            {
                case 0:
                    // Restarts the game
                    MyGame.Run();
                    return;
                case 1:
                    ConsoleUtils.QuitConsole();
                    break;
            }
        }
    }
    }
}
