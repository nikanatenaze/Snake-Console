using Snake.Design;
using Snake.GameClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Menu
{
    internal class Menu
    {
        public static void Start()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Background.TurnOn();
                    Custom.Title();
                    Custom.Line();
                    Say.Green("1", "Play");
                    Say.Green("2", "Settings");
                    Say.Red("Any", "Exit");
                    Console.Write(" Option: ");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        SnakeClass snake = new SnakeClass();
                        Console.Clear();
                        snake.Run();
                    }
                    else if (option == 2)
                    {
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Say.Red("Error", $"Message: {ex.Message}");
                }
            }
        }
    }
}
