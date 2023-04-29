using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments.Arrays
{
    class Assignment3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string data = Console.ReadLine();
            countFunc(data);
        }

        private static void countFunc(string data)
        {
            int alpha = 0, digits = 0, specialchar = 0;
            for(int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= 65 && data[i] <= 90) || (data[i] >= 97 && data[i] <= 122))
                    alpha++;
                else if (Char.IsDigit(data[i]))
                    digits++;
                else
                    specialchar++;

            }
            Console.WriteLine("The number of alphabets in given string is "+alpha);
            Console.WriteLine("The number of digts in given string is "+digits);
            Console.WriteLine("The number of special characters in given string is "+specialchar);
        }
    }
}
