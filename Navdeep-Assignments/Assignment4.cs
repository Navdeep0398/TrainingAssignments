using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments
{
    class Assignment4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the {i + 1} value of array");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The values of the array are");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
