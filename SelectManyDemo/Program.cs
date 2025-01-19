using SelectManyDemo;

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Name = "A", Age = 18, Scores = new List<int> { 1, 2, 3 } },
            new Student { Name = "B", Age = 15, Scores = new List<int> { 7, 8, 9 } },
            new Student { Name = "C", Age = 20, Scores = new List<int> { 8, 9, 10 } },
            new Student { Name = "D", Age = 21, Scores = new List<int> { 2, 3, 4 } },
            new Student { Name = "E", Age = 21, Scores = new List<int> { 2, 3, 4 } },
            new Student { Name = "F", Age = 18, Scores = new List<int> { 2, 3, 4 } },
        };

        var firstStudent = students.FirstOrDefault(x => x.Age > 20);// Name = D;..s
        //var firstStudent = students.FirstOrDefault(x => x.Age > 30);// null

        var lastStudent = students.LastOrDefault(x => x.Age > 30);

        //var singleStudent = students.SingleOrDefault(x => x.Age > 15);
        


        //["A", "B", "C", "D"]
        var studentNames = students.Select(x => x.Name).ToList();

        //var studentNames = students.Select(x => x.Scores).ToList();
        // [[ 1, 2, 3 ], [ 7, 8, 9 ], [ 8, 9, 10 ] , [ 2, 3, 4 ]]

        //[1,2,3,7,8,9,8,9,10,2,3,4]
        var scores = students.SelectMany(x => x.Scores).ToList();
        //SelectMany phải đi vào 1 cái list ở trong 1 list đg đc trỏ tới

        foreach (var score in scores)
        {
            Console.WriteLine(score);
        }

        var orderStudent = students.OrderBy(x => x.Age).ToList();

        var orderStudent2 = students.OrderByDescending(x => x.Age).ToList();

        var groupStudents = students.GroupBy(x => x.Age).ToList();

        var student2 = students.Skip(3).Take(2).ToList();

        int[] nums = new int[] { 1, 2, 3, 4, 5 };
        var sum = nums.Sum();

        var totalAge = students.Average(x => x.Age);   

        var numGreaterThan18 = students.Count(x => x.Age > 18);

        var maxAge = students.Max(x => x.Age > 18);

        var minAge = students.Min(x => x.Age > 18);

        var isGreaterThan18 = students.Any(x => x.Age > 18);

        var isNotEmpty = students.Any();

        List<int> numbers1 = new List<int>() { 1, 1, 2, 3, 4, 4};
        List<int> numbers2 = new List<int>() { 1, 2, 3};
        var nums2 = numbers1.Distinct().ToList();

        //
        var numbers3 = numbers1.Concat(numbers2).ToList();

        // 
        var numbers4 = numbers1.Union(numbers2).ToList();

        // 1 2 3 
        var numbers5 = numbers1.Intersect(numbers2).ToList();

        // 4
        var numbers6 = numbers1.Except(numbers2).ToList();

        Console.WriteLine("Space--------");
        Console.WriteLine(sum);
    }
}