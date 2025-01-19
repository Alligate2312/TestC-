using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    internal class Order
    {
        public string Customer { get; set; }
        public List<Fruit> Product {  get; set; }

        public void Print()
        {
            Console.WriteLine("Customer: " + this.Customer);
            Console.WriteLine("{0,9} | {1,8} | {2,5} | {3,7}",
                              "Product",
                              "Quantity", 
                              "Price", 
                              "Amount");
            foreach (var item in this.Product)
            {
                item.PrintInOrder();
            }
            Console.WriteLine("Total: {0:0}", this.Product.Sum(x => x.Quantity * x.Price));
        }
    }
}
