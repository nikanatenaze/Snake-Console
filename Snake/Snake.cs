using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Movement { get; set; }
        Board Board { get; set; } = new Board();
        Ball Ball { get; set; }

        ConsoleKeyInfo ConsoleKeyInfo { get; set; }
        ConsoleKey Key { get; set; }

        public Snake()
        {
            this.Width = 50;
            this.Height = 25;
            ConsoleKeyInfo = new ConsoleKeyInfo();
            Board = new Board();
            Ball = new Ball(Width, Height);
        }
        public void Input()
        {
            if(Console.KeyAvailable)
            {
                ConsoleKeyInfo = Console.ReadKey(true);
                Key = ConsoleKeyInfo.Key;
            }
        }

        public void Run()
        {
            Console.CursorVisible = false;
            while (true)
            {
                Board.Write();
                bool succes = Ball.Move();
                if(succes)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKey key = Console.ReadKey(true).Key;

                        if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                        {
                            Ball.Movement = "up";
                        }
                        else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                        {
                            Ball.Movement = "down";
                        }
                        else if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                        {
                            Ball.Movement = "right";
                        }
                        else if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                        {
                            Ball.Movement = "left";
                        }
                    }
                    Thread.Sleep(50);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
