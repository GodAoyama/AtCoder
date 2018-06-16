using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long ans = 0;
        for (int i = 0; i < n; i++)
        {
            while (a[i] % 2 == 0)
            {
                a[i] /= 2;
                ans++;
            }
        }
        Console.WriteLine(ans);
    }
}
