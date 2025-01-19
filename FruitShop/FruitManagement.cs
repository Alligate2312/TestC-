using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    internal class FruitManagement
    {
        static List<Fruit> fruits = new List<Fruit>();

        public void addFruit()
        {
            Fruit fruit = new Fruit();
            int id;
            bool isDup = false;
            do
            {
                Console.WriteLine("Enter Fruit Id: ");
                id = Convert.ToInt32(Console.ReadLine());
                if(fruits.FirstOrDefault(x => x.Id == id) != null)
                {
                    isDup = true;
                    Console.WriteLine("This id has already been used");
                }
            }
            while (isDup);

            fruit.Id = id;
            Console.WriteLine("Enter Fruit Name: ");
            fruit.Name = Console.ReadLine();

            Console.WriteLine("Enter Fruit Price: ");
            fruit.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fruit Qunatity: ");
            fruit.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fruit Origin: ");
            fruit.Origin = Console.ReadLine();

            fruits.Add(fruit);
        }

        public void listFruit()
        {
            if(fruits.Count == 0 )
            {
                Console.WriteLine("Nothing here");
                return;
            }

            foreach (var item in fruits)
            {
                item.Print();
            }
        }

        public void listFruitInShop()
        {
            if (fruits.Count == 0)
            {
                Console.WriteLine("Nothing here");
                return;
            }

            foreach (var item in fruits)
            {
                int num = 0;
                if(item.Quantity > 0)
                {
                    Console.WriteLine("{0,8}|{1,14}|{2,10}|{3,9:0}|", 
                                       ++num,  
                                       item.Name,
                                       item.Origin,
                                       item.Price);
                }
            }
        }
    }
}
