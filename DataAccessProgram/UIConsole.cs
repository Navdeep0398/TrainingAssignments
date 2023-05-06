using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessProgram
{
    class UIConsole
    {
        internal static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        internal static int GetNumber(string question)
        {
            Console.WriteLine(question);
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }
        internal static double GetDouble(string question)
        {
            return double.Parse(GetString(question));
        }
        internal static DateTime GetDate(string question)
        {
            Console.WriteLine(question);
            DateTime answer = DateTime.Parse(Console.ReadLine());
            return answer;
        }
        internal static void PrintMessage(string message)
        {
            var oldBgColor = Console.BackgroundColor;
            var oldFgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.BackgroundColor = oldBgColor;
            Console.ForegroundColor = oldFgColor;
        }
        internal static void PrintError(string message)
        {
            var oldBgColor = Console.BackgroundColor;
            var oldFgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ForegroundColor = oldFgColor;
            Console.BackgroundColor = oldBgColor;
        }
        internal static void ClearScreen()
        {
            Console.Clear();
        }
    }
}
