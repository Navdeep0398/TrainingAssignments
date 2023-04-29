using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments.Arrays
{
    class Assignment4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string ori_str = Console.ReadLine();
            string new_str = changeString(ori_str);
            Console.WriteLine("Original string: "+ori_str);
            Console.WriteLine("New string: "+new_str);
        }

        private static string changeString(string ori_str)
        {
            string new_str = "";
            for(int i = 0; i < ori_str.Length; i++)
            {
                if (Char.IsUpper(ori_str[i]))
                    new_str += Char.ToLower(ori_str[i]);
                else
                    new_str += Char.ToUpper(ori_str[i]);
            }
            return new_str;
        }
    }
}
