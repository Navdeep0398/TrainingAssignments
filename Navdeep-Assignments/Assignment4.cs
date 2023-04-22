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
            Console.WriteLine("Enter the CTS equivalent Data Type of the Array");
            string typeName = Console.ReadLine();
            Type selectedDataType = Type.GetType(typeName, false, true);
            if (selectedDataType == null)
            {
                Console.WriteLine("Sorry ,The CTS is invalid");
                return;
            }
            Array arr = Array.CreateInstance(selectedDataType, n);
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Please Enter the {i+1} value of type {selectedDataType.Name}");
                arr.SetValue(Convert.ChangeType(Console.ReadLine(),selectedDataType), i);
            }
            Console.WriteLine("The values of the array are");
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
