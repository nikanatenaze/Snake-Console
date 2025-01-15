using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Board(int Width, int Height) {
            this.Width = Width;
            this.Width = Height;
        }

        public Board()
        {
            this.Width = 50;
            this.Height = 25;
        }

        public void Write()
        {
            // With borders
            for (int i = 0; i <= Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("═");
            }
            for (int i = 0; i <= Width; i++)
            {
                Console.SetCursorPosition(i, Height);
                Console.WriteLine("═");
            }
            // Height borders
            for (int i = 0; i <= Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("║");
            }
            for (int i = 0; i <= Height; i++)
            {
                Console.SetCursorPosition(Width, i);
                Console.WriteLine("║");
            }
            // Rounds
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("╔");
            Console.SetCursorPosition(Width, 0);
            Console.WriteLine("╗");
            Console.SetCursorPosition(Width, Height);
            Console.WriteLine("╝");
            Console.SetCursorPosition(0, Height);
            Console.WriteLine("╚");
        }
    }
}
