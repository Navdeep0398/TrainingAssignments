using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments
{
    class Assignment9
    {
        static void reverseSentence(string str)
        {
            string [] arr = str.Split(' ');
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            bool flag = false;
            do{

                Console.WriteLine("Enter the sentence to print its reverse");
                string sen = Console.ReadLine();
                reverseSentence(sen);
                Console.WriteLine("Press true to continue or press false to exit");
                flag = bool.Parse(Console.ReadLine());
            } while (flag);
        }
    }
}
