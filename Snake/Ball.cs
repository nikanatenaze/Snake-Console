using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Ball
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Movement { get; set; }

        public Ball(int Width, int Height) {
            Movement = "up";
            this.Width = Width;
            this.Height = Height;
            X = Width / 2;
            Y = Height / 2;
        }
        public Ball()
        {
            Movement = "up";
            this.Width = 50;
            this.Height = 25;
            X = Width / 2;
            Y = Height / 2;
        }

        public void Up()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
            Y--;
            Write();
        }

        public void Down()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
            Y++;
            Write();
        }

        public void Right()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
            X++;
            Write();
        }

        public void Left()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
            X--;
            Write();
        }

        public bool Move()
        {
            if (Check())
            {
                if (Movement == "up")
                {
                    Up();
                }
                if (Movement == "down")
                {
                    Down();
                }
                if (Movement == "left")
                {
                    Left();
                }
                if (Movement == "right")
                {
                    Right();
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
            if (X == 0 || X == Width) { return false;}
            if (Y == 0 || Y == Height) { return false;}
            return true;
        }

        public void Write()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("■");
        }
    }
}
