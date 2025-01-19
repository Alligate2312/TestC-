using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    internal class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Origin { get; set; }

        public decimal Amount()
        {
            return this.Price * this.Quantity;
        }

        public void Print()
        {
            Console.WriteLine(this.Id + ", " + 
                              this.Name + ", " + 
                              this.Origin + ", " + 
                              this.Price + ", " + 
                              this.Quantity);
        }

        public void PrintInOrder()
        {
            Console.WriteLine("{0,9} | {1,8} | {2,5} | {3,7}",
                              this.Name,
                              this.Quantity,
                              this.Price,
                              this.Amount());
        }

    }
}
