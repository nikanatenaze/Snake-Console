using Snake.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.GameClasses
{
    public class SnakeClass
    {
        public int Width { get; set; }
        public int Height { get; set; }
        Board Board { get; set; } = new Board();
        Ball Ball { get; set; }

        ConsoleKeyInfo ConsoleKeyInfo { get; set; }
        ConsoleKey Key { get; set; }
        public SnakeClass()
        {
            Width = 50;
            Height = 25;
            ConsoleKeyInfo = new ConsoleKeyInfo();
            Board = new Board();
            Ball = new Ball(Width, Height);
        }
        public void Input()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo = Console.ReadKey(true);
                Key = ConsoleKeyInfo.Key;
            }
        }

        public void Run()
        {
            Background.TurnOn();
            Console.CursorVisible = false;
            while (true)
            {
                Board.Write();
                bool succes = Ball.Move();
                if (succes)
                {
                    if (Console.KeyAvailable)
                    {
                        Key = Console.ReadKey(true).Key;

                        if (Key == ConsoleKey.W || Key == ConsoleKey.UpArrow)
                        {
                            Ball.Direction.y = -1;
                            Ball.Direction.x = 0;
                        }
                        else if (Key == ConsoleKey.S || Key == ConsoleKey.DownArrow)
                        {
                            Ball.Direction.y = 1;
                            Ball.Direction.x = 0;
                        }
                        else if (Key == ConsoleKey.D || Key == ConsoleKey.RightArrow)
                        {
                            Ball.Direction.x = 1;
                            Ball.Direction.y = 0;
                        }
                        else if (Key == ConsoleKey.A || Key == ConsoleKey.LeftArrow)
                        {
                            Ball.Direction.x = -1;
                            Ball.Direction.y = 0;
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

        public void LoseMenu()
        {
            while(true)
            {
                Console.WriteLine(" ██╗   ██╗ ██████╗ ██╗   ██╗    ██╗      ██████╗ ███████╗████████╗\r\n ╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║     ██╔═══██╗██╔════╝╚══██╔══╝\r\n ╚████╔╝ ██║   ██║██║   ██║    ██║     ██║   ██║███████╗   ██║   \r\n  ╚██╔╝  ██║   ██║██║   ██║    ██║     ██║   ██║╚════██║   ██║   \r\n   ██║   ╚██████╔╝╚██████╔╝    ███████╗╚██████╔╝███████║   ██║   \r\n   ╚═╝    ╚═════╝  ╚═════╝     ╚══════╝ ╚═════╝ ╚══════╝   ╚═╝ ");
                Custom.Line();
                Say.Green("1", "Play again");
                Say.Green("Any", "To menu");
                Console.Write(" Option: ");
                int option = int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    Console.Clear();
                    Run();
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
