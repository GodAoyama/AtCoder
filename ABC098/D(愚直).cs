using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        var xor = new long[n];
        long ans = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (xor[j] != -1 && ((xor[j] ^ a[i]) == (xor[j] + a[i])))
                {
                    ans++;
                    xor[j] ^= a[i];
                }
                else xor[j] = -1;
            }
        }
        Console.WriteLine(ans);
    }
}
