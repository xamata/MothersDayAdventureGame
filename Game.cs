using MothersDayAdventureGame.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MothersDayAdventureGame
{
    internal class Game
    {
        public TitleScene MyTitleScene;
        public DenScene MyDenScene;
        public BackyardScene MyBackyardScene;
        public FrontyardScene MyFrontyardScene;
        public RoomScene MyRoomScene;
        public KitchenScene MyKitchenScene;

        public Game()
        {
            MyTitleScene = new TitleScene(this);
            MyDenScene = new DenScene(this);

        }
        public void Run()
        {
            MyTitleScene.Run();

            ConsoleUtils.WaitForKeyPress();
        }
    }
}
