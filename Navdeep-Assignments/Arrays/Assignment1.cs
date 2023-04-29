using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments.Arrays
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of column");
            int col = int.Parse(Console.ReadLine());
            int[,] arr = new int[row,col];
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.WriteLine("Enter value at position"+i+":"+j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Array before tranpositon");
            printArray(arr);
            arr = transpose(arr);
            Console.WriteLine("Array before tranpositon");
            printArray(arr);

        }

        private static void printArray(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] transpose(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);
            int[,] temp = new int[col, row];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    temp[i, j] = arr[j, i];
                }
            }
            return temp;
        }
    }
}
