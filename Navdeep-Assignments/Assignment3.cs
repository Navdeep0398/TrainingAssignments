using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments
{
    class Assignment3
    {
        public static int inputValue(string stat)
        {
            Console.WriteLine(stat);
            int val = int.Parse(Console.ReadLine());
            return val;
        }
        public static void addition()
        {
            Console.WriteLine($"The value after addition {inputValue("Enter the 1st No.") + inputValue("Enter the 2nd No.")}");
        }
        public static void subtraction()
        {
            
            Console.WriteLine($"The value after subtraction {inputValue("Enter the 1st No.") - inputValue("Enter the 2nd No.")}");
        }
        public static void multiplication()
        {
            
            Console.WriteLine($"The value after multiplication {inputValue("Enter the 1st No.") * inputValue("Enter the 2nd No.")}");
        }
        public static void division()
        {
            
            Console.WriteLine($"The value after division {inputValue("Enter the 1st No.") / inputValue("Enter the 2nd No.")}");
        }
        public static void modolus()
        {
           
            Console.WriteLine($"The value after modulus {inputValue("Enter the 1st No.") % inputValue("Enter the 2nd No.")}");
        }
        static void square()
        {
            int val = inputValue("Enter the  Number");
            Console.WriteLine($"The value after square { val* val}");
        }
        static void sqroot()
        {
           
            Console.WriteLine($"The value after square root {Math.Sqrt((double)inputValue("Enter the  Number"))}");
        }
        static void Main(string[] args)
        {
            bool flag = false;
            do {
                Console.WriteLine("Enter the operation to perform like + - * / % sq sqroot");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "+":
                        addition();
                        break;
                    case "-":
                        subtraction();
                        break;
                    case "*":
                        multiplication();
                        break;
                    case "/":
                        division();
                        break;
                    case "%":
                        modolus();
                        break;
                    case "sq":
                        square();
                        break;
                    case "sqroot":
                        sqroot();
                        break;
                }
                
                Console.WriteLine("Enter true to continue or false to exit");
                flag = bool.Parse(Console.ReadLine());
                Console.Clear();
            } while(flag!=false);
        }
    }
}
