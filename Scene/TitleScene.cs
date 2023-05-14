using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MothersDayAdventureGame.Scene
{
    internal class TitleScene : Scene
    {
        public TitleScene(Game game) : base(game) { }
        
        public void Run()
        {
            string prompt = "Title scene";
            string[] options = { "Play", "About", "Exit" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();
            
            switch(selectedIndex)
            {
                case 0:
                    // TODO: Display Den Scene
                    break;
                case 1:
                    // TODO: Display About Info
                    break;
                case 2:
                    ConsoleUtils.QuitConsole();
                    break;
            }
            ConsoleUtils.WaitForKeyPress();
        }

        private void DisplayAboutInfo()
        {

        }
    }
}
