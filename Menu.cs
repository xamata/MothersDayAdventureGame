using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MothersDayAdventureGame
{
    internal class Menu
    {
        // Fields
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            // First option at Index 0
            SelectedIndex = 0;
        }

        // Method responsible for rendering the menu to the screen
        private void DisplayOptions()
        {
            // Display prompt before selection area
            WriteLine(Prompt);

            // Selection area
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                // Adds * and white background to hovered option
                if (i == SelectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                // Prints options with respected style
                WriteLine($"{prefix} << {currentOption} >>");
                ResetColor();
            }
        }

        // Displays a selectable menu that updates with down/up/enter keys
        public int Run()
        {
            ConsoleKey keyPressed;
            // Loop gets a key from the user
            do
            {
                Clear();
                DisplayOptions();
                // Gets key input from user
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                // Update Sele ctedIndex based on arrow keys. 
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    SelectedIndex -= 1;
                    if (SelectedIndex < 0)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    SelectedIndex += 1;
                    if (SelectedIndex > Options.Length - 1)
                    {
                        SelectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            Clear();
            return SelectedIndex;
        }
    }
}
