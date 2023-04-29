using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Navdeep_Assignments
{
    class Patient
    {
        public int patientId { get; set; }
        public string patientName { get; set; }
        public int patientNumber { get; set; }
        public double patientBillAmount { get; set; }
    }
    class Assignment14
    {
        static string filePath = "PatientData.csv";
        static void Main(string[] args)
        {
            
            bool flag = false;
            do
            {
                showMenu();
                int choice = int.Parse(Console.ReadLine());
                choiceHelper(choice);
                Console.WriteLine("Enter true to continue or false to exit");
                flag = bool.Parse(Console.ReadLine());
                Console.Clear();
            } while (flag);
        }

        private static void choiceHelper(int choice)
        {
            switch (choice)
            {
                case 1:
                    addPatient();
                    break;
                case 2:
                    List<Patient> data = readPatient();
                    foreach(var i in data)
                    {
                        Console.WriteLine(i.patientName+"-----"+i.patientId+"-----"+i.patientNumber+"------"+i.patientBillAmount);
                    }
                    break;
            }
        }

        private static void addPatient()
        {
            Patient obj = new Patient();
            obj.patientId = UIConsole.GetInt("Enter the Id of the Patient");
            obj.patientName = UIConsole.GetString("Enter the Name of the Patient");
            obj.patientNumber = UIConsole.GetInt("Enter the Phone number of the Patient");
            obj.patientBillAmount = UIConsole.GetDouble("Enter the bill amount of the Patient");
            string data = $"{obj.patientId},{obj.patientName},{obj.patientNumber},{obj.patientBillAmount}\n";
            File.AppendAllText("PatientData.csv", data);
            Console.WriteLine("Patient Data is added successfully to the file");
        }


        private static List<Patient> readPatient()
        {
            List<Patient> temp = new List<Patient>();

            string[] lines = File.ReadAllLines("PatientData.csv");
            foreach(string line in lines)
            {
                string[] data = line.Split(',');
                temp.Add(new Patient()
                {
                    patientId = int.Parse(data[0]),
                    patientName = data[1],
                    patientNumber = int.Parse(data[2]),
                    patientBillAmount = double.Parse(data[3])
                }) ;
            }
            return temp;
        }

        static void showMenu()
        {
            Console.WriteLine("--------------Patient Manager-------------");
            Console.WriteLine("To Add Details ---------------Press 1");
            Console.WriteLine("To See Details ---------------Press 2");
            Console.WriteLine("-------------------------------------");
        }
    }
}
