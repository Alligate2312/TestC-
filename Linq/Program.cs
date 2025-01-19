using Linq;

class Program
{
    static void Main()
    {
        int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };

        Func<int, bool> isEven = x => x % 2 == 0;
        //Func<int, bool> isEven = x => { return x % 2 == 0; };

        var nums2 = nums.Where(x => x % 2 == 0);
        //var nums2 = nums.Where(isEven);

        var nums3 = nums.Select(x => x * 2);

        Print(nums3);

        var students = new List<Student>
        {
            new Student { Name = "A", Age = 18 },
            new Student { Name = "B", Age = 15 },
            new Student { Name = "C", Age = 20 },
            new Student { Name = "D", Age = 21 },
        };

        //var studentHasAgeGreaterThan18 = new List<Student>();
        //foreach (var student in students)
        //{
        //    if (student.Age > 18)
        //    {
        //        studentHasAgeGreaterThan18.Add(student);
        //    }
        //}
        var studentHasAgeGreaterThan18 = students
            .Where(x => { Console.WriteLine(x.Name); return x.Age > 18; });

        var studentHasAgeLessThan24 = studentHasAgeGreaterThan18
            .Where(X => X.Age < 24)
            .ToList();
        
        var studentHasAgeLessThan254 = studentHasAgeGreaterThan18
            .Where(X => X.Age < 25)
            .ToList();
        //KQ: A, B, C, D, A, B, C, D
        /*
         vì khi code chạy tới where thì chương trình nó chưa thật sự trả ra kết quả ngay,
        do C# thường sẽ cố gắng tối giản code của nó

        để execute thì thường thêm các method liên quan tới trả ra giá trị như ToList, Count, ...
         */

        var total = studentHasAgeGreaterThan18.Count();
    }

    public static void Print(IEnumerable<int> nums)
    {
        foreach (var num in nums)
        {
            Console.WriteLine(num); 
        }
    }
}