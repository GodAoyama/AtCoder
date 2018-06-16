using System;
class Program
{
    static void Main()
    {
        var inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(inp[0] <= 8 && inp[1] <= 8 ? "Yay!" : ":(");
    }
}
