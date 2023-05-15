using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MothersDayAdventureGame.Scene
{
    internal class DenScene : Scene
    {
        public DenScene(Game game): base(game)
        {
        }

        public void Run()
        {
            string prompt = @$"DEN SCENE";
            string[] options = { "Backyard", "Frontyard", "Room", "Kitchen" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.MyBackyardScene.Run();
                    break;
                case 1:
                    MyGame.MyFrontyardScene.Run();
                    break;
                case 2:
                    MyGame.MyRoomScene.Run();
                    break;
                case 3:
                    if (MyGame.MyPlayer.HasDye && MyGame.MyPlayer.HasFlowers)
                    {
                        MyGame.MyKitchenScene.Run();
                    }
                    else
                    {
                        WriteLine("Mom is in there, I better not go in!");
                        ConsoleUtils.WaitForKeyPress();
                        Run();
                    };
                    break;
            }
        }
    }
}
