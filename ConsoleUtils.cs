﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MothersDayAdventureGame
{
    internal class ConsoleUtils
    {
        static void WaitForKeyPress()
        {
            Console.WriteLine("(Press any key to continue...)");
            Console.ReadKey(true);
        }
        }
    }
}
