using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    internal class OrderManagement
    {
        static List<Order> orders = new List<Order>()
                    {
                        new Order
                        {
                            Customer = "Marrie",
                            Product =
                            {
                                new Fruit{ Id = 1, Name = "Mango", Origin = "VN", Price = 3, Quantity = 2},
                                new Fruit{ Id = 2, Name = "Banana", Origin = "VN", Price = 2, Quantity = 1}
                            }
                        }
                    };

        public void viewOrder()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("Nothing here");
                return;
            }

            foreach (var item in orders)
            {
                item.Print();
            }
        }
    }
}
