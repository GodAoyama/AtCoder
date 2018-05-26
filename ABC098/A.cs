using System;

class Program
{
    static void Main()
    {
        var inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int a = inp[0] + inp[1];
        int b = inp[0] - inp[1];
        int c = inp[0] * inp[1];
        int ans = (int)Math.Max(a, b);
        Console.WriteLine((int)Math.Max(ans, c));
    }
}
