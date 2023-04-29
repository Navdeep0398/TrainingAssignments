using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Navdeep_Assignments
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public int EmployeeSalary { get; set; }
    }
    interface IDataComponent
    {
        void Add(Employee employee);
        void Remove(int id);
        void Update(Employee employee);
        void FindID(int id);
        void FindByName(string name);

    }

    class CustomerFile : IDataComponent
    {
        string filepath = "Employee15.csv";
        public void Add(Employee employee)
        {

            string content = $"{employee.EmployeeId},{employee.EmployeeName},{employee.EmployeeAddress},{employee.EmployeeSalary}\n";
            File.AppendAllText(filepath, content);
            Console.WriteLine("The Employee data has been added successfully");
        }

        public void FindByName(string name)
        {
            List<Employee> EmpArr = GetEmployees();
            foreach (var i in EmpArr)
            {
                if (i.EmployeeName == name)
                {
                    Console.WriteLine($"Employee {i.EmployeeName} with id {i.EmployeeId} and address {i.EmployeeAddress} is having salary {i.EmployeeSalary}");
                    return;
                }
            }
            Console.WriteLine("Sorry such employee is not in the records");
        }

        public void FindID(int id)
        {
            List<Employee> EmpArr = GetEmployees();
            foreach (var i in EmpArr)
            {
                if (i.EmployeeId == id)
                {
                    Console.WriteLine($"Employee {i.EmployeeName} with id {i.EmployeeId} and address {i.EmployeeAddress} is having salary {i.EmployeeSalary}");
                    return;
                }
            }
            Console.WriteLine("Sorry such employee is not in the records");
        }

        public void Remove(int id)
        {
            List<Employee> EmpArr = GetEmployees();
            foreach (var i in EmpArr)
            {
                if (i.EmployeeId == id)
                {
                    EmpArr.Remove(i);
                    Console.WriteLine("The Employee with id " + id + " has been deleted successfully");
                    UpdateFile(EmpArr);
                    return;
                }
            }
            Console.WriteLine("Sorry, Not able to delete such employee");
        }

        public void Update(Employee employee)
        {
            List<Employee> EmpArr = GetEmployees();
            foreach (var i in EmpArr)
            {
                if (i.EmployeeId == employee.EmployeeId && i.EmployeeName == employee.EmployeeName)
                {
                    i.EmployeeId = employee.EmployeeId;
                    i.EmployeeName = employee.EmployeeName;
                    i.EmployeeAddress = employee.EmployeeAddress;
                    i.EmployeeSalary = employee.EmployeeSalary;
                    Console.WriteLine("The Employee with id " + i.EmployeeId + " has been updated successfully");
                    UpdateFile(EmpArr);
                    return;
                }
            }
            Console.WriteLine("Sorry, Not able to delete such employee");
        }

        public void UpdateFile(List<Employee> newList)
        {
            string content = "";
            foreach(var i in newList)
            {
                 content += $"{i.EmployeeId},{i.EmployeeName},{i.EmployeeAddress},{i.EmployeeSalary}\n";
            }
            File.WriteAllText(filepath, content);
        }
        public static List<Employee> GetEmployees()
        {
            List<Employee> temp = new List<Employee>();
            string[] lines = File.ReadAllLines("Employee15.csv");
            foreach (string line in lines)
            {
                
                string[] EmpArr = line.Split(',');
           
                temp.Add(new Employee()
                {
                    EmployeeId = int.Parse(EmpArr[0]),
                    EmployeeName = EmpArr[1],
                    EmployeeAddress = EmpArr[2],
                    EmployeeSalary = int.Parse(EmpArr[3])
                });
            }
            return temp;
        }
    }
    class Assignment15
    {
        const string menuPath = @"C:\Training\Basics\Assignments\Navdeep-Assignments\Assignment15Menu.txt";

        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                int choice = UIConsole.GetInt(File.ReadAllText(menuPath));
                choiceDriver(choice);
                Console.WriteLine("Press true to continue or Press false to exit");
                flag = bool.Parse(Console.ReadLine());
                Console.Clear();

            } while (flag);
        }

        private static void choiceDriver(int choice)
        {
            IDataComponent obj = new CustomerFile();
            switch (choice)
            {
                case 1:
                    AddHelper(obj);
                    break;
                case 2:
                    RemoveHelper(obj);
                    break;
                case 3:
                    UpdateHelper(obj);
                    break;
                case 4:
                    FindIdHelper(obj);
                    break;
                case 5:
                    FindNameHelper(obj);
                    break;
            }
        }

        private static void AddHelper(IDataComponent obj)
        {
            Employee temp = new Employee();
            temp.EmployeeId = UIConsole.GetInt("Enter the Id of the Employee");
            temp.EmployeeName = UIConsole.GetString("Enter the Name of the Employee");
            temp.EmployeeAddress = UIConsole.GetString("Enter the Address of the Employee");
            temp.EmployeeSalary = UIConsole.GetInt("Enter the Salary of the Employee");
            obj.Add(temp);
        }

        private static void RemoveHelper(IDataComponent obj)
        {
            int id = UIConsole.GetInt("Enter the Id of the Employee to remove");
            obj.Remove(id);
        }
        private static void UpdateHelper(IDataComponent obj)
        {
            Employee temp = new Employee();
            temp.EmployeeId = UIConsole.GetInt("Enter the Id of the Employee");
            temp.EmployeeName = UIConsole.GetString("Enter the Name of the Employee");
            temp.EmployeeAddress = UIConsole.GetString("Enter the Address of the Employee");
            temp.EmployeeSalary = UIConsole.GetInt("Enter the Salary of the Employee");
            obj.Update(temp);
        }
        private static void FindIdHelper(IDataComponent obj)
        {
            int id = UIConsole.GetInt("Enter the Id of the Employee to Search");
            obj.FindID(id);
        }

        private static void FindNameHelper(IDataComponent obj)
        {
            string name = UIConsole.GetString("Enter the Name of the Employee to Search");
            obj.FindByName(name);
        }

    }
}
