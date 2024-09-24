public class Program
{
    public static void Main(string[] args)
    {
        string input = "";
        var output = add(input);
        Console.WriteLine(output);
    }

    public static int add(string numbers)
    {
        var nums = numbers.Split(',').Select(x => !string.IsNullOrEmpty(x) ? int.Parse(x) : 0);
        return nums.Sum(n => n);
    }
}