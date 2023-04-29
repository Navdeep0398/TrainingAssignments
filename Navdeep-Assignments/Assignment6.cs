using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments
{
    class Assignment6
    {
        static Dictionary<int, int> dRecords = new Dictionary<int, int>();

        static bool LeapYear(int year)
        {
            if (year % 4 == 0 || year%400==0)
            {
                return true;
            }
            return false;
        }
        static bool validate(int dd,int mm,int year)
        {
            if(mm>=1 && mm <= 12)
            {
                if (mm == 2 && LeapYear(year))
                {
                    if (dd > 0 && dd <= 29)
                        return true;
                    else return false;
                }
                else if (dd >0 && dd <= dRecords[mm])
                {
                    return true;
                }
            }
            return false;
        }
        static void AddValues()
        {
            dRecords.Add(1,31);
            dRecords.Add(2, 28);
            dRecords.Add(3, 31);
            dRecords.Add(4, 30);
            dRecords.Add(5, 31);
            dRecords.Add(6, 30);
            dRecords.Add(7, 31);
            dRecords.Add(8, 31);
            dRecords.Add(9, 30);
            dRecords.Add(10, 31);
            dRecords.Add(11, 30);
            dRecords.Add(12, 31);
        }
        static void Main(string[] args)
        {
            AddValues();
            bool flag = false;
            do
            {
                int dd = UIConsole.GetInt("Enter the date");
                int mm = UIConsole.GetInt("Enter the month");
                int year = UIConsole.GetInt("Enter the year");
                if (validate(dd, mm, year))
                {
                    Console.WriteLine($"The Date {dd}/{mm}/{year} is valid");
                }
                else
                {
                    Console.WriteLine($"The Date {dd}/{mm}/{year} is not valid");
                }
                Console.WriteLine("Press true to continue or Press false to exit");
                flag = bool.Parse(Console.ReadLine());
                Console.Clear();
            } while (flag);
        }
    }
}
