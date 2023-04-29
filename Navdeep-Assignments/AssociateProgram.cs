using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments
{
    class Bill
    {
        List<Item> list = new List<Item>();
        public int BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public string BillHolder { get; set; }
        public int BillAmount { get; private set; }

        public void newItem()
        {
            Console.WriteLine("Enter the id of the item");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the detail of the item");
            string detail = Console.ReadLine();
            Console.WriteLine("Enter the price of the item");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the quantity of the item");
            int quantity = int.Parse(Console.ReadLine());
            list.Add(new Item()
            {
                ItemId = id,
                ItemDetail = detail,
                ItemPrice = price,
                ItemQuantity = quantity
            }) ;
        }
        public void TotalBillAmount()
        {
            int sum = 0;
            foreach(Item i in list)
            {
                sum += (i.ItemPrice*i.ItemQuantity);
            }
            BillAmount = sum;
        }


    }
    class Item
    {
        public int ItemId { get; set; }
        public string ItemDetail { get; set; }
        public int ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
    }
    class AssociateProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Id of the customer");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the date of purchase by customer");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the Customer");
            string name = Console.ReadLine();
            Bill obj = new Bill()
            {
                BillNo = no,
                BillDate = date,
                BillHolder = name
            };
            bool flag = false;
            do
            {
                obj.newItem();
                Console.WriteLine("Press true to enter another item or false to exit");
                flag = bool.Parse(Console.ReadLine());

            } while (flag);
            obj.TotalBillAmount();
            Console.WriteLine($"The Customer {obj.BillHolder} with id {obj.BillNo} has the bill of {obj.BillAmount}");

        }
    }
}
