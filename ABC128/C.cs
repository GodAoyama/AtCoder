using System;
using System.Linq;
using System.Collections.Generic;
class c
{
    static void Main()
    {
        var nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var list = new List<List<int>>();
        for (int i = 0; i < nm[1]; i++)
        {
            var line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            list.Add(line.ToList());
        }
        var hash = new int[nm[1]];
        for (int i = 0; i < nm[1]; i++)
        {
            for (int j = 1; j < list[i].Count(); j++)
            {
                hash[i] += (int)Math.Pow(2, list[i][j] - 1);
            }
        }
        var p = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int ans = 0;
        for (int i = 0; i < Math.Pow(2, nm[0]); i++)
        {
            for (int j = 0; j < nm[1]; j++)
            {
                var temp = i & hash[j];
                var cnt = 0;
                for (int k = 0; k < nm[0]; k++)
                {
                    if ((temp >> k & 1) == 1) cnt++;
                }
                if (cnt % 2 != p[j]) break;
                if (j == nm[1] - 1) ans++;
            }
        }
        Console.WriteLine(ans);
    }
}
