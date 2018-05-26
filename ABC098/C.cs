using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var s = Console.ReadLine();
        var W = new int[n];
        if (s[n - 1] == 'W') W[n - 1] = 1;
        var E = new int[n];
        if (s[0] == 'E') E[0] = 1;
        var Leader = new int[n];

        for (int i = 1; i < n; i++)
            E[i] = E[i - 1] + (s[i] == 'E' ? 1 : 0);
        for (int i = n - 2; i >= 0; i--)
            W[i] = W[i + 1] + (s[i] == 'W' ? 1 : 0);
        for (int i = 0; i < n; i++)
            Leader[i] = E[i] + W[i];
        Console.WriteLine(n - Leader.Max());
    }
}
