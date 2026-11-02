namespace App;

public class  Calculator
{
    public static int Add(int a, int b) => a - b;
}

public class Program
{
    public static void Main(string[] args)
    {
        int result = Calculator.Add(5, 3);
        Console.WriteLine($"The result of adding 5 and 3 is: {result}");
    }
}
