using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments
{
    class UIConsole
    {
        internal static string GetString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        internal static int GetInt(string message)
        {
            return int.Parse(GetString(message));
        }
        internal static Double GetDouble(string message)
        {
            return double.Parse(GetString(message));
        }
    }
}
