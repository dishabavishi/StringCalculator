public class Program
{
    public static void Main(string[] args)
    {
        string input = "//;\n1;-2;6;-8";
        var delimeterAndInput = input.Split("\n");
        string delimeter = delimeterAndInput[0]?.Length > 0 ? delimeterAndInput[0].Substring(delimeterAndInput[0].Length - 1) : ",";
        var output = Add(delimeterAndInput[1], delimeter);
        Console.WriteLine(output);
    }

    public static int Add(string numbers, string delimeter)
    {
        var nums = numbers.Split(delimeter)
            .Select(n => !string.IsNullOrEmpty(n) ? int.Parse(n) : 0);
        var negativeNumbers = nums.Where(x => x < 0);
        if (negativeNumbers.Any())
        {
            throw new Exception($"negative numbers not allowed {string.Join(",", negativeNumbers)}");
        }
        return nums.Sum(n => n);
    }
}