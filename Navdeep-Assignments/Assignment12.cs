using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Navdeep_Assignments
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class CustomerRepo
    {
        const int size = 100;
        private Customer[] customerRec = new Customer[size];
        public void AddCustomer(Customer customer)
        {
            for(int i = 0; i < customerRec.Length; i++)
            {
                if (customerRec[i] == null)
                {
                    customerRec[i] = new Customer() {
                        Id = customer.Id,
                        Name = customer.Name
                    };
                    Console.WriteLine($"The customer with id: {customer.Id} and name: {customer.Name} added successfully");
                    return;
                }
            }
        }
        public void DeleteCustomer(int id)
        {
            for(int i = 0; i < customerRec.Length; i++)
            {
                if (customerRec[i]!=null && customerRec[i].Id == id)
                {
                    customerRec[i] = null;
                    Console.WriteLine($"The customer with id: {id} deleted successfully");
                    return;
                }
                
            }
        }
        public Customer[] FindCustomer(string detail)
        {
            int count = 0;
            for (int i = 0; i < customerRec.Length; i++)
            {
                if(customerRec[i]!=null && customerRec[i].Name.Contains(detail))
                {
                    count++;
                }
            }
            Customer[] temp = new Customer[count];
            int tempcount = 0;
            foreach(Customer cus in customerRec)
            {
                if(cus!=null && cus.Name.Contains(detail))
                {
                    temp[tempcount++] = cus;
                }
            }

            return temp;
        }
        public void UpdateCustomer(Customer customer)
        {
            for(int i = 0; i < customerRec.Length; i++)
            {
                if(customerRec[i]!=null && customerRec[i].Id == customer.Id)
                {
                    customerRec[i].Id = customer.Id;
                    customerRec[i].Name = customer.Name;
                    Console.WriteLine($"The given customer is updated");
                    return;
                }
            }
        }
    }

    class Assignment12
    {
        const string FilePath = @"C:\Training\Basics\Assignments\Navdeep-Assignments\Menu.txt";
       static CustomerRepo records = new CustomerRepo();
        static void Main(string[] args)
        {
            string menu = GetMenu();
            bool processing = true;
            do
            {
                int choice = UIConsole.GetInt(menu);
                processing = processMenu(choice);
                ClearScreen();
            } while (processing);
            
        }

        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    addingCustomerHelper();
                    return true;
                case 2:
                    deletingCustomerHelper();
                    return true;
                case 3:
                    updatingCustomerHelper();
                    return true;
                case 4:
                    findingCustomerHelper();
                    return true;
                default:
                    return false;

            }
        }

        private static void findingCustomerHelper()
        {
            string detail = UIConsole.GetString("Enter the details or part of detail to find the customer");
            Customer[] arr = records.FindCustomer(detail);
            if (arr != null)
            {
                foreach(Customer i in arr)
                {
                    Console.WriteLine($"{i.Id}---->{i.Name}");

                }
            }
            else
            {
                Console.WriteLine("Sorry, No such record found");
            }
        }

        private static void updatingCustomerHelper()
        {
            Customer obj = new Customer();
            obj.Id = UIConsole.GetInt("Enter the id of the customer");
            obj.Name = UIConsole.GetString("Enter the name of the customer");
            records.UpdateCustomer(obj);
            
        }

        private static void deletingCustomerHelper()
        {
            int id = UIConsole.GetInt("Enter the id of the customer to delete");
            records.DeleteCustomer(id);
        }

        private static void addingCustomerHelper()
        {
            Customer obj = new Customer();
            obj.Name = UIConsole.GetString("Enter the Name of the customer");
            obj.Id = UIConsole.GetInt("Enter the id of the customer");
            records.AddCustomer(obj);
            
        }

        static string GetMenu()
        {
            return File.ReadAllText(FilePath);
        }
        static void ClearScreen()
        {
            Console.WriteLine("Press any key to clear the screen");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
