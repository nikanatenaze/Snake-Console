using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.GameClasses
{
    public class SnakeC : Main
    {
        public static List<(int x, int y)> Parts = new List<(int x, int y)>();
        public static (int x, int y) Direction { get; set; }
        public SnakeC()
        {
            Direction = (0, -1);
            Parts.Add((Width / 2, Height / 2));
        }

        public bool Move()
        {
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
                if (newHead.Item1 == FoodCords.X && newHead.Item2 == FoodCords.Y)
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

        public bool Run()
        {
            while(true)
            {
                if (!Move())
                {
                    return false;
                }
            }
        }

        public bool Check()
        {
            (int, int) FirstPart = Parts[0];
            if (FirstPart.Item1 == 0 || FirstPart.Item1 == Width) { return false; }
            if (FirstPart.Item2 == 0 || FirstPart.Item2 == Height) { return false; }
            return true;
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
