public class Program
{
    public static void Main(string[] args)
    {
        string input = "1\n2,3";
        var output = add(input);
        Console.WriteLine(output);
    }

    public static int add(string numbers)
    {
        var nums = numbers.Split(',')
            .SelectMany(x => x.Split("\n"))
            .Select(n => !string.IsNullOrEmpty(n) ? int.Parse(n) : 0);
        return nums.Sum(n => n);
    }
}