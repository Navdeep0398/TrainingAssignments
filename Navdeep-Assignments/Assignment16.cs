using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Navdeep_Assignments
{
    static class SerializationComponent
    {
        const string fileName = "Employee.xml";
        public  static List<Employee> loadData()
        {
            
            XmlSerializer fm = new XmlSerializer(typeof(List<Employee>));
            var loc = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            var temp = fm.Deserialize(loc) as List<Employee>;
            return temp;
        }
        public static void saveData(List<Employee> data) {
            var dataToSerialize = data;
            XmlSerializer fm = new XmlSerializer(typeof(List<Employee>));
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fm.Serialize(fs,dataToSerialize);
            fs.Close();
            Console.WriteLine("Employee Data is Serialized");
        }
    }
    class Assignment16
    {  
        static void Main(string[] args)
        {
            List<Employee> data = csvFileRead();
            menu();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SerializationComponent.saveData(data);
                    break;
                case 2:
                    List<Employee> receivedData = SerializationComponent.loadData();
                    showData(receivedData);
                    break;
            }
        }

        private static void showData(List<Employee> receivedData)
        {
            foreach(Employee i in receivedData)
            {
                Console.WriteLine($"{i.EmployeeId}-->{i.EmployeeName}-->{i.EmployeeAddress}-->{i.EmployeeSalary}");
            }
        }

        private static void menu()
        {
            Console.WriteLine("------------Xml Serailzer and Deserializer---------------");
            Console.WriteLine("To Serialize-----------------------------Press 1");
            Console.WriteLine("To Deserialize---------------------------Press 2");

        }

        private static List<Employee> csvFileRead()
        {
            List<Employee> employees = new List<Employee>();
            var lines = File.ReadAllLines(@"C:\Training\Basics\Assignments\Navdeep-Assignments\bin\Debug\Employee15.csv");
            foreach(var line in lines)
            {
                string[] data = line.Split(',');
                employees.Add(new Employee()
                {
                    EmployeeId = int.Parse(data[0]),
                    EmployeeName = data[1],
                    EmployeeAddress = data[2],
                    EmployeeSalary = int.Parse(data[3])
                }) ;
            }
            return employees;
        }
    }
}
