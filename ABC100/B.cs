using System;
class Program
{
    static void Main()
    {
        var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int x = a[1];
        if (a[1] == 100) x = 101;
        Console.WriteLine(x * Math.Pow(100, a[0]));
    }
}
