using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>()
        {
            new Order
            {
                CreatedAt = new DateTime(2024, 2, 10),
                CreatedBy = "An",
                Items = new List < Item >
                {
                    new Item { Name = "Item 1", Quantity = 2, Price = 100 },//200
                    new Item { Name = "Item 2", Quantity = 3, Price = 200 },//600
                }
            },

            new Order
            {
                CreatedAt = new DateTime(2024, 2, 15),
                CreatedBy = "Binh",
                Items = new List < Item >
                {
                    new Item { Name = "Item 1", Quantity = 1, Price = 100 },//100
                    new Item { Name = "Item 2", Quantity = 2, Price = 200 },//400
                    new Item { Name = "Item 3", Quantity = 3, Price = 250 },//750
                }
            },

            new Order
            {
                CreatedAt = new DateTime(2024, 2, 20),
                CreatedBy = "An",
                Items = new List < Item >
                {
                    new Item { Name = "Item 2", Quantity = 3, Price = 200 },//600
                    new Item { Name = "Item 3", Quantity = 1, Price = 200 },//200
                    new Item { Name = "Item 4", Quantity = 2, Price = 200 },//400
                }
            },

            new Order
            {
                CreatedAt = new DateTime(2024, 2, 25),
                CreatedBy = "An",
                Items = new List < Item >
                {
                    new Item { Name = "Item 1", Quantity = 1, Price = 200 },//200
                    new Item { Name = "Item 4", Quantity = 1, Price = 250 },//250
                }
            }
        };

        var result = //TotalAmount(orders, new DateTime(2024, 2, 10), new DateTime(2024, 2, 11));
                     CountOrdersByPerson(orders, "an"); 
                     //CalculateAmountOfFirstOrder(orders);

        Console.WriteLine(result);
    }
    // 1. Find the total amount of the first order
    public static decimal CalculateAmountOfFirstOrder(List<Order> orders)
    {
        //decimal result = 0;
        //var itemList = orders
        //                .Take(1)
        //                .SelectMany(x => x.Items);
        //foreach (var item in itemList)
        //{
        //    result += item.Quantity * item.Price;
        //}
        //return result;

        return orders.FirstOrDefault().Items.Sum(x => x.Quantity * x.Price);
    }

    // 2. Find how many orders were created by a specific person
    public static int CountOrdersByPerson(List<Order> orders, string person)
    {
        return orders.Count(x => x.CreatedBy.Equals(person, StringComparison.OrdinalIgnoreCase));
                                                            //So sánh ko phân biệt hoa thường
    }

    // 3. Find how many orders were created from fromDate to toDate
    public static decimal CountOrdersByTimeRange(List<Order> orders, DateTime fromDate, DateTime toDate)
    {
        return orders.Count(x => (x.CreatedAt >= fromDate && x.CreatedAt <= toDate)); ;
    }

    // 4. Find the total amount of all orders from fromDate to toDate
    public static decimal TotalAmount(List<Order> orders, DateTime fromDate, DateTime toDate)
    {
        //var orderList = orders.Where(x => (x.CreatedAt >= fromDate && x.CreatedAt <= toDate)).ToList();
        //var itemList = orderList.SelectMany(x => x.Items);
        
        //decimal result = 0;
        //foreach (var item in itemList)
        //{
        //    result += item.Quantity * item.Price;
        //}
        //return result;

        return orders.Where(x => x.CreatedAt >= fromDate && x.CreatedAt <= toDate)
                     .SelectMany(x => x.Items)
                     .Sum(x => x.Quantity * x.Price);
    }
}

public class Order

{
    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public List<Item> Items { get; set; }

}

public class Item

{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}