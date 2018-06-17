using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var nm = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        var ans = new long[8];
        var inp = new long[nm[0]][];
        for (int i = 0; i < nm[0]; i++) inp[i] = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        for (int i = 0; i < 8; i++)
        {
            var score = new List<long>();
            for (int j = 0; j < nm[0]; j++)
            {
                long thisScore = 0;
                for (int k = 0; k < 3; k++)
                {
                    if ((i >> k & 1) == 1) thisScore += inp[j][k];
                    else thisScore -= inp[j][k];
                }
                score.Add(thisScore);
            }
            ans[i] = score.OrderByDescending(L => L).Where((x, y) => y < nm[1]).Sum();
        }
        Console.WriteLine(ans.Max());
    }
}
