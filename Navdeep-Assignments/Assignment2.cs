using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments
{
    class Assignment2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers to check odd and even");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the value {i+1} value");
                arr[i] = int.Parse(Console.ReadLine());
            }
            string odd = "\n";
            string even = "\n";
            foreach(int i in arr)
            {
                if (i % 2 == 0)
                {
                    even = even+ i + "\n";
                }
                else
                {
                    odd = odd + i + "\n";
                }
            }
            Console.WriteLine($"The even numbers are {even}");
            Console.WriteLine($"The odd numbers are {odd}");
        }
    }
}
