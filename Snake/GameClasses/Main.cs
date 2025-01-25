using Snake.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.GameClasses
{
    public class Main
    {
        public int Width { get; set; }
        public int Height { get; set; }
        Board Board { get; set; }
        public (int X, int Y) FoodCords { get; set; }
        public bool FoodExists { get; set; }

        public void GenerateFood()
        {
            Random random = new Random();
            if (!FoodExists)
            {
                int X = random.Next(1, Width - 1);
                int Y = random.Next(1, Height - 1);
                FoodCords = (X, Y);
                FoodExists = true;
                Console.SetCursorPosition(X, Y);
                Console.WriteLine("×");
            }
        }

        public Main(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
            Board = new Board(Width, Height);
        }

        public Main()
        {
            Width = 50;
            Height = 25;
            Board = new Board();
        }
    }
}
