using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.GameClasses
{
    internal class Ball
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool FoodExists { get; set; } = false;
        public (int, int) FoodXY { get; set; }
        public static List<(int x, int y)> Parts = new List<(int x, int y)>();
        public static (int x, int y) Direction = (0, -1);

        public Ball(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
            Parts.Add((Width / 2, Height / 2));
        }
        public Ball()
        {
            Width = 50;
            Height = 25;
            Parts.Add((Width / 2, Height / 2));
        }

        public bool Move()
        {
            GenerateFood();
            if (Check())
            {
                var newHead = (Parts[0].x + Direction.x, Parts[0].y + Direction.y);
                for (int i = 0; i < Parts.Count; i++)
                {
                    Console.SetCursorPosition(Parts[i].x, Parts[i].y);
                    Console.WriteLine(" ");
                }
                for (int i = Parts.Count - 1; i > 0; i--)
                {
                    Parts[i] = Parts[i - 1];
                }
                Parts[0] = newHead;
                if (newHead.Item1 == FoodXY.Item1 && newHead.Item2 == FoodXY.Item2)
                {
                    Parts.Insert(0, newHead);
                    FoodExists = false;
                }
                Write();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Check()
        {
            (int, int) FirstPart = Parts[0];
            if (FirstPart.Item1 == 0 || FirstPart.Item1 == Width) { return false; }
            if (FirstPart.Item2 == 0 || FirstPart.Item2 == Height) { return false; }
            return true;
        }

        public void GenerateFood()
        {
            Random random = new Random();
            if (!FoodExists)
            {
                int X = random.Next(1, Width - 1);
                int Y = random.Next(1, Height - 1);
                FoodXY = (X, Y);
                FoodExists = true;
                Console.SetCursorPosition(X, Y);
                Console.WriteLine("×");
            }
        }

        public void Write()
        {
            foreach (var i in Parts)
            {
                Console.SetCursorPosition(i.x, i.y);
                Console.WriteLine("O");
            }
        }
    }
}
