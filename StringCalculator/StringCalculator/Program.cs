public class Program
{
    public static void Main(string[] args)
    {
        string input = "//;\n1;2;3;5";
        var delimeterAndInput = input.Split("\n");
        string delimeter = delimeterAndInput[0]?.Length > 0 ? delimeterAndInput[0].Substring(delimeterAndInput[0].Length - 1) : ",";
        var output = Add(delimeterAndInput[1], delimeter);
        Console.WriteLine(output);
    }

    public static int Add(string numbers, string delimeter)
    {
        var nums = numbers.Split(delimeter)
            .Select(n => !string.IsNullOrEmpty(n) ? int.Parse(n) : 0);
        return nums.Sum(n => n);
    }
}