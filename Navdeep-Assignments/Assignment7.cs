using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments
{
    class Assignment7
    {
        static bool isPrimeNumber(int num)
        {
            if(num > 1)
            {
                for(int i = 2; i <=(int)Math.Sqrt((double)num); i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                Console.WriteLine("Enter the number to check whether it is prime or not");
                int num = int.Parse(Console.ReadLine());
                if (isPrimeNumber(num))
                {
                    Console.WriteLine("The number is prime");
                }
                else
                {
                    Console.WriteLine("The number is not prime");
                }
                Console.WriteLine("Press true to continue or false to exit");
                flag = bool.Parse(Console.ReadLine());
            } while(flag);
        }
    }
}
