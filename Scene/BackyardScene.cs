using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MothersDayAdventureGame.Scene
{
    internal class BackyardScene : Scene
    {
        public BackyardScene(Game game) : base(game) { }

        public void Run()
        {
            string prompt = @$"Backyard SCENE";
            string[] options = { "Go into the shed","Go back inside" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    // TODO: if has flashlight pick a paint, else too dark go back
                    MyGame.MyShedScene.Run();
                    break;
                case 1:
                    MyGame.MyDenScene.Run();
                    break;
            }
            ConsoleUtils.WaitForKeyPress();
        }
    }
}
