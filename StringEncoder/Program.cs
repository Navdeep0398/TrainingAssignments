using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncoder
{
    class Program
    {
        static string point(string [] input_arr,char c)
        {
            string result = "";
            for(int i = 0; i < input_arr.Length; i++)
            {
                string temp = input_arr[i];
                if (temp.Contains(c))
                {
                    //Console.WriteLine("check:"+temp.IndexOf(c));
                    return result += i + "" + temp.IndexOf(c);
                }
            }
            return result;
        }
        static void Encoder(string input,string input_ref)
        {
            
            try
            {
                if (string.IsNullOrEmpty(input_ref) || string.IsNullOrEmpty(input)) {
                    throw new NullReferenceException("NullReferenceException");
                }
                string[] input_arr = input_ref.Split(' ');
                string[] data = input.Split(' ');
                string ret_value = "";
                for (int i = 0; i < data.Length; i++)
                {
                    string temp = data[i];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        string value = point(input_arr, Char.ToLower(temp[j]));
                        //Console.WriteLine("The vlaue is"+ value);
                        ret_value += value + ",";
                    }
                    ret_value = ret_value.Substring(0, ret_value.Length - 1);
                    ret_value += '-';
                    
                }
                Console.WriteLine(ret_value.Substring(0, ret_value.Length - 1));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

        //Virtual Guidance should be available, U ask a Question and User gives the Input
        static void Main(string[] args)
        {
            string input_ref= "the quick and brown fox jumps over the lazy dog";//Should have made a const and used it at the class level.
            
            try
            {
                Console.WriteLine("Enter the string to encode");
                string input = Console.ReadLine();
                if (input.Length < 1)
                {
                    throw new ArgumentException("ArgumentException");
                }
                Encoder(input, input_ref);
                
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
