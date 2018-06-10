using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var nc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var D = new int[nc[1], nc[1]];
        var C = new int[nc[0], nc[0]];
        for (int i = 0; i < nc[1]; i++)
        {
            var inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < nc[1]; j++) D[i, j] = inp[j];
        }
        for (int i = 0; i < nc[0]; i++)
        {
            var inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < nc[0]; j++) C[i, j] = inp[j];
        }
        var group0 = new List<int>();
        var group1 = new List<int>();
        var group2 = new List<int>();
        for (int i = 0; i < nc[0]; i++)
        {
            for (int j = 0; j < nc[0]; j++)
            {
                if ((i + j) % 3 == 0) group0.Add(C[i, j]);
                else if ((i + j) % 3 == 1) group1.Add(C[i, j]);
                else if ((i + j) % 3 == 2) group2.Add(C[i, j]);
            }
        }
        var group = new List<int>[] { group0, group1, group2 };

        var ans = new int[3, nc[1]];//groupNo,colors
        for (int i = 0; i < 3; i++)//group
        {
            for (int j = 0; j < nc[1]; j++)//color
            {
                int dif = 0;
                for (int k = 0; k < group[i].Count(); k++)
                {
                    dif += D[group[i][k] - 1, j];
                }
                ans[i, j] = dif;
            }
        }
        int minDif = int.MaxValue;
        for (int i = 0; i < nc[1]; i++)
        {
            for (int j = 0; j < nc[1]; j++)
            {
                for (int k = 0; k < nc[1]; k++)
                {
                    if (i == j || j == k || k == i) continue;
                    minDif = Math.Min(minDif, ans[0, i] + ans[1, j] + ans[2, k]);
                }
            }
        }
        Console.WriteLine(minDif);
    }
}
