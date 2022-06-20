using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.App
{
    public static class Cli
    {
        static void ShowEndL(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void ShowInfo(string massage)
        {
            ShowEndL(massage, ConsoleColor.Blue);
        }
        public static void ShowError(string massage)
        {
            ShowEndL(massage, ConsoleColor.Red);
        }
        public static string Input(string message)
        {
            Show(message, ConsoleColor.DarkGray);
            return Console.ReadLine();
        }
        static void Show(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
