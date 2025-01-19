using FruitShop;

class Program
{
    public static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Please choose a function to continue");
            Console.WriteLine("1. Create Fruit");
            Console.WriteLine("2. View Order");
            Console.WriteLine("3. Shopping");
            Console.WriteLine("4. Exit");

            choice = Convert.ToInt32(Console.ReadLine());
            if(choice < 1 || choice > 4)
            {
                Console.WriteLine("There no suitable fuction");
                continue;
            }

            FruitManagement fruitManagement = new FruitManagement();
            OrderManagement orderManagement = new OrderManagement();

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Create Fruit Function");

                    string answer;
                    bool isCont = true;

                    do
                    {
                        fruitManagement.addFruit();

                        Console.Write("Do you want to continue (Y/N): ");
                        answer = Console.ReadLine();
                        if (answer.Equals("N", StringComparison.OrdinalIgnoreCase))
                        {
                            isCont = false;
                        }
                    }
                    while (isCont);

                    Console.WriteLine("Fruit List:");
                    fruitManagement.listFruit();

                    break;

                case 2:
                    Console.WriteLine("View Order Function");
                    
                    orderManagement.viewOrder();

                    break;

                case 3:
                    Console.WriteLine("Shopping Time!!");
                    Console.WriteLine("|++Item++|++FruitName++|++Origin++|++Price++|");
                    fruitManagement.listFruitInShop();

                    break;

                default:
                    Console.WriteLine();
                    break;
            }
        }
        while (choice != 4);
    }
}