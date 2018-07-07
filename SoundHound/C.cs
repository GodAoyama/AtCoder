using System;
class Program
{
    static void Main()
    {
        var inp = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        double n = inp[0];
        double m = inp[1];
        double d = inp[2];
        double p = d == 0 ? n : (n - d) * 2;
        Console.WriteLine(p * (m - 1) / Math.Pow(n, 2));
    }
}
