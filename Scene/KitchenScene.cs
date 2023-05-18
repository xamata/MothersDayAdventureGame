using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MothersDayAdventureGame.Scene
{
    internal class KitchenScene : Scene
    {
        public KitchenScene(Game game) : base(game)
        {
            
        }

        public void Run()
        {
            string prompt = @$"{TextArt.KitchenArt}";
            string[] options = { "Give mom gifts", "Leave room" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    DisplayGift();
                    MyGame.MyCreditScene.Run();
                    break;
                case 1:
                    MyGame.MyDenScene.Run();
                    break;
            }
        }
        
        public void DisplayGift()
        {
            MyGame.MyPlayer.PickUpDye(ConsoleColor.Blue);
            ForegroundColor = MyGame.MyPlayer.PaintColor;
            WriteLine(TextArt.FlowerGift);
            ResetColor();
            WriteLine("You give mom the flowers you picked up.");
            WriteLine("She loves them dearly and gives you a big hug and kiss!");
            ConsoleUtils.WaitForKeyPress();
        }
    }
}
