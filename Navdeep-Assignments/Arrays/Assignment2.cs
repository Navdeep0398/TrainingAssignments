using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments.Arrays
{
    class Assignment2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of rows");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int col = int.Parse(Console.ReadLine());
            int[,] arr = createArray(row, col);
            arr = newArray(arr);
            printArray(arr);
        }

        private static void printArray(int[,] arr)
        {
            Console.WriteLine("New array : ");
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] newArray(int[,] arr)
        {
            int[,] temp = new int[arr.GetLength(0), arr.GetLength(1) + 1];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    temp[i, j] = arr[i, j];
                    sum += arr[i, j];
                }
                temp[i, arr.GetLength(1)] = sum;
            }
            return temp;
        }

        private static int[,] createArray(int row, int col)
        {
            int[,] temp = new int[row, col];
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.WriteLine("Enter the value at "+i+":"+j);
                    temp[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return temp;
        }
    }
}
