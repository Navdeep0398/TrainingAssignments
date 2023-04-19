using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments
{
    class Assignment3
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do {
                Console.WriteLine("Enter the 1st value");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 2nd value");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the operation to perform like + - * / %");
                char c = char.Parse(Console.ReadLine());
                switch (c)
                {
                    case '+':
                        Console.WriteLine($"The value after addition is {a + b}");
                        break;
                    case '-':
                        Console.WriteLine($"The value after subtraction is {a - b}");
                        break;
                    case '*':
                        Console.WriteLine($"The value after multiplication is {a * b}");
                        break;
                    case '/':
                        Console.WriteLine($"The value after division is {a / b}");
                        break;
                    case '%':
                        Console.WriteLine($"The value reminder is {a % b}");
                        break;

                }
                Console.WriteLine("Enter true to continue or false to exit");
                flag = bool.Parse(Console.ReadLine());
            } while(flag!=false);
        }
    }
}
