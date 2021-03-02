using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ourbank = new Bank("Bangladesh bank", 5);
            Address address = new Address("10", "12/2A", "Dhaka", "Bangladesh");
            Account account1 = new Account("jon", 5000, address);

           //  ourbank.AddAccount(account1);
            // ourbank.PrintAccountDetails(1);

            ourbank.AddAccount(new Account("alex", 6000, new Address("13", "12/4C", "Dhaka", "Bangladesh")));
             ourbank.PrintAccountDetails(2);

           // ourbank.AddAccount(new Account("angel", 7000, new Address("12", "11/4C", "ctg", "Bangladesh")));
            //  ourbank.PrintAccountDetails(3);




          
        }
    }
}



