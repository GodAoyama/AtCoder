using System;
using System.Linq;
using System.Collections.Generic;
class c
{
    static void Main()
    {
        var nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = nk[0];
        int k = nk[1];
        var ansList = new List<int>();
        ansList.Add(0);
        for (int i = k; i >= k / 2; i--)
        {
            for (int j = 0; j <= i; j++)
            {
                var jewel = new List<int>();
                for (int l = 0; l < n; l++)
                {
                    if (l < j || n - i + j<= l) jewel.Add(v[l]);
                }
                jewel = jewel.OrderBy(f => f).ToList();
                for (int l = 0; l < k - i; l++)
                {
                    if (jewel.Any() && jewel[0] < 0) jewel.RemoveAt(0);
                    else break;
                }
                ansList.Add(jewel.Sum());
            }
        }
        Console.WriteLine(ansList.Max());
    }
}
