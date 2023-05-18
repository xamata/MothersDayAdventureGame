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
        public bool HasDye { get; private set; }
        public ConsoleColor PaintColor { get; private set; }

        public Player() {
            HasFlashlight = false;
            HasMarble = false;
            HasDye = false;
        }

        public void PickUpDye(ConsoleColor color)
        {
            HasDye = true;
            PaintColor = color;
        }

        public void ResetItems()
        {
            HasFlashlight = false;
            HasMarble = false;
            HasDye = false;
            HasFlowers = false;
        }
    }
}
