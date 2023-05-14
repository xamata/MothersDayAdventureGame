using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            menu.Run();
        }
    }
}
