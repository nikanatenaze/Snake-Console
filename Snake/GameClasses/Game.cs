using Snake.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.GameClasses
{
    public class Game
    {
        public int Width { get; set; }
        public int Height { get; set; }
        Board Board { get; set; } = new Board();
        Snake Sneak { get; set; }
        public (int X, int Y) FoodCords { get; set; }
        public bool FoodExists { get; set; }
        ConsoleKeyInfo ConsoleKeyInfo { get; set; }
        ConsoleKey Key { get; set; }

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

        public Game()
        {
            Width = 50;
            Height = 25;
            ConsoleKeyInfo = new ConsoleKeyInfo();
            Board = new Board();
            this.Sneak = new Snake(Width, Height, (0, -1));
        }

        private void createNewGame()
        {
            Board = new Board();
            Sneak = new Snake(Width, Height, (0, -1));
        }

        public void Run()
        {
            Background.TurnOn();
            Console.CursorVisible = false;
            Key = ConsoleKey.ExSel;
            while (true)
            {
                Board.Write();
                createNewGame();
                Sneak.Move();

                Thread.Sleep(50);
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
