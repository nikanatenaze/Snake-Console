using Pong_Console.Menu;
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
        public static Main i = new Main();
        public static void Start()
        {
            var values = new List<string>() { "Play", "Exit" };
            var methods = new List<Action>() { Play, Exit};
            GameMenu gm = new GameMenu(values, methods);
            gm.Execute();
        }

        public static void Play() {
            i.Run();
        }

        public static void Exit() {
            Environment.Exit(0);
        }
    }
}
