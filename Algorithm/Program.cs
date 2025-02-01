class Program
{
    public static void Main()
    {
        int n;
        Console.Write("Enter range of array: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element " + i + ":");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The array elements are:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }

        int result = missingNum(array);
        Console.WriteLine("\nResult: " + result);
    }

    public static int missingNum(int[] array)
    {
        int num = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                num++;
                i = 0;
            }
        }
        return num;
    }
}