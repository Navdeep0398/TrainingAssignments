using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navdeep_Assignments
{
    abstract class BankAccount
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Balance {  get;  private set; }
        public void CreditOperation(int amount)
        {
            Balance += amount;
        }
        public void DebitOperation(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }
        public abstract void CalculateInterest();

    }

    class SBAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            int rate = 4;
            int term = UIConsole.GetInt("Enter the no of days for which you have to calculate the interest");
            int interest = (Balance * rate * term )/100;
            Console.WriteLine($"The Saving Account of {Name} with id: {id} has the Balance {Balance} with interest {interest} on it ");
            
        }
    }
    class FDAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            int rate = 10;
            int term = UIConsole.GetInt("Enter the no of years for which you have to calculate the interest");
            int interest = (Balance * rate * term ) /100;
            Console.WriteLine($"The Fixed Deposit Account of {Name} with id: {id} has the Balance {Balance} with interest {interest} on it ");

        }
    }
    class RDAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            double rate = 0.049;
            int n = 4;
            int term = UIConsole.GetInt("Enter the no of years for which you have to calculate the interest");
            double interest = Math.Pow((Balance *( 1+ (rate/n ))),(n*(term/12))) ;
            Console.WriteLine($"The RDAccount of {Name} with id: {id} has the Balance {Balance} with interest {interest} on it ");

        }
    }
    class Assignment13
    {
        public static BankAccount ObjectType(string type)
        {
            if (type == "SBAccount")
                return new SBAccount();
            else if (type == "FDAccount")
                return new FDAccount();
            else
                return new RDAccount();
        }
        static void Main(string[] args)
        {
            string type = UIConsole.GetString("Enter the type of Account\nSBAccount\nFDAccount\nRDAccount");
            BankAccount obj = ObjectType(type);
            obj.id = UIConsole.GetInt("Enter the Id");
            obj.Name = UIConsole.GetString("Enter the Account Holder Name");
            obj.CreditOperation(UIConsole.GetInt("Enter the Amount to Credit"));
            Console.WriteLine("---------Interest--------------");
            obj.CalculateInterest();
        }
    }
}
