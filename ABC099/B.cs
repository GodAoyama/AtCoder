using System;

class Program
{
    static void Main()
    {
        var ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = ab[1] - ab[0] - 1;
        int sum = 0;
        for (int i = 1; i <= n; i++) sum += i;
        Console.WriteLine(sum - ab[0]);
    }
}
