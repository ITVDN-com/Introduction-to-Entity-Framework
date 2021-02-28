using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer newCustomer = new Customer
            {
                 CusomerId = 1,
                  Name = "Alex",
                   Phone = "0630001122"
            };

            Order newOrder = new Order
            {
                OrderDate = DateTime.Now,
                OrderId = 1
            };

            newCustomer.Order.Add(newOrder);

            MyShopContainer context = new MyShopContainer();

            context.Customers.Add(newCustomer);
            context.OrderSet.Add(newOrder);

            context.SaveChanges();
        }
    }
}
