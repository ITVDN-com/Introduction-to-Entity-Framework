using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopDB_EFEntities contxet = new ShopDB_EFEntities();

            foreach (var customer in contxet.Customers)
            {
                Console.WriteLine(customer.LName +" "+ customer.FName);
                Console.WriteLine(customer.Phone);

                Console.WriteLine();
            }
        }
    }
}
