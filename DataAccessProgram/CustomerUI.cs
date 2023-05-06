using AssignmentsDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessProgram
{
    class CustomerUI
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                int choice = Menu();
                try
                {
                    menuHelper(choice);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("To contiune enter true or enter false");
                flag = bool.Parse(Console.ReadLine());
                Console.Clear();
            } while (flag);
            
        }

        private static void menuHelper(int choice)
        {
            switch (choice)
            {
                case 1: addingCustomer(); break;
                case 2: updatingCustomer(); break;
                case 3: deletingCustomer(); break;
                case 4: showingData(); break;
            }
        }

        private static void updatingCustomer()
        {
            CustomerInfo temp = new CustomerInfo();
            temp.CustomerId = UIConsole.GetNumber("Enter Customer Id whom you want to update");
            temp.CustomerName = UIConsole.GetString("Enter the Name of the Customer");
            temp.CustomerAddress = UIConsole.GetString("Enter address of Customer");
            temp.CustomerPhone = UIConsole.GetNumber("Enter Phone number");
            temp.CustomerBillAmt = UIConsole.GetNumber("Enter the bill amount");
            temp.CustomerBillDate = UIConsole.GetString("Enter date in format:YYYY-MM-DD");
            ICustomerDB obj = CustomerFactory.GetComponent();
            obj.UpdateCustomer(temp);
            Console.WriteLine("Customer Updated Successfully");
        }

        private static void deletingCustomer()
        {
            int id = UIConsole.GetNumber("Enter the id of Customer whom you want to delete");
            ICustomerDB obj = CustomerFactory.GetComponent();
            obj.DeleteCustomer(id);
            Console.WriteLine("The customer is deleted successfully");
        }

        private static void addingCustomer()
        {
            CustomerInfo temp = new CustomerInfo();
            temp.CustomerName = UIConsole.GetString("Enter the Name of the Customer");
            temp.CustomerAddress = UIConsole.GetString("Enter address of Customer");
            temp.CustomerPhone = UIConsole.GetNumber("Enter Phone number");
            temp.CustomerBillAmt = UIConsole.GetNumber("Enter the bill amount");
            temp.CustomerBillDate = UIConsole.GetString("Enter date in format:YYYY-MM-DD");
            ICustomerDB obj = CustomerFactory.GetComponent();
            obj.AddNewCustomer(temp);
            Console.WriteLine("Customer Detail entered successfully");
            
        }

        private static int Menu()
        {
            Console.WriteLine("-----------Customer Detail Manager----------------");
            Console.WriteLine("To Add new Customer Detail-----------------Press 1");
            Console.WriteLine("To Update Customer Detail------------------Press 2");
            Console.WriteLine("To Delete Customer Detail------------------Press 3");
            Console.WriteLine("To Show all records------------------------Press 4");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        private static void showingData()
        {
            ICustomerDB obj = CustomerFactory.GetComponent();
            var dataList = obj.GetAllCustomer();
            foreach(var data in dataList)
            {
                Console.WriteLine(data.CustomerName);
            }
        }
    }
}
