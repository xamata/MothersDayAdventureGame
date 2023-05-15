using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MothersDayAdventureGame
{
    internal class Player
    {
        public bool HasFlashlight { get; set; }
        public bool HasMarble { get; set; }
        public bool HasFlowers { get; set; }
        public bool HasPaint { get; private set; }
        public ConsoleColor PaintColor { get; private set; }

        public Player() {
            HasFlashlight = false;
            HasMarble = false;
            HasPaint = false;
        }

        public void PickUpPaint(ConsoleColor color)
        {
            HasPaint = true;
            PaintColor = color;
        }


    }
}
