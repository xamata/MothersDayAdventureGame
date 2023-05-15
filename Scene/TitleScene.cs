using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Figgle;

namespace MothersDayAdventureGame.Scene
{
    internal class TitleScene : Scene
    {
        public TitleScene(Game game) : base(game) { }
        
        public void Run()
        {
            string prompt = @$"{FiggleFonts.FlowerPower.Render("Mom's Gift")}
You just arrived home and something terrible has happened. You forgot to stop by the
store and get your mom a gift for her birthday! You hear in the other room... Quick!
Go find a gift!";
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
