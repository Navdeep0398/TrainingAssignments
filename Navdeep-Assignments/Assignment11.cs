using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments
{
    class Assignment11
    {
        static void simpleInterest(params object [] arr)
        {
            double si = ((double)arr[0] * (int)arr[1] * (int)arr[2]) / 100;
            Console.WriteLine($"The simple interest on principal {arr[0]} on rate {arr[1]} in {arr[2]} years is {si}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principal amount");
            double principal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest");
            int rate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time");
            int time = int.Parse(Console.ReadLine());
            simpleInterest(principal, rate, time);
        }
    }
}
