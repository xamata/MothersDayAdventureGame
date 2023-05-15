using static System.Console;
namespace MothersDayAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "Mom's Gift Adventure Game";
            CursorVisible = false;

            try
            {
                WindowHeight = 35;
                WindowWidth = 115;
            }
            catch {
                WriteLine("Cannot create a big enough console window.");
                WriteLine("Try adjusing your font/console settings and restarting.");
                WriteLine("You can continue playing, just be aware that some art might not render properly!.");
                ConsoleUtils.WaitForKeyPress();
            }

            Game myGame = new Game();
            myGame.Start();
        }
    }
}