using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var list = new List<int>();
        list.Add(1);
        for (int i = 1; i <= 6; i++) list.Add((int)Math.Pow(6, i));
        for (int i = 1; i <= 5; i++) list.Add((int)Math.Pow(9, i));
        list = list.OrderByDescending(x => x).ToList();
        var ans = Enumerable.Repeat(int.MaxValue, 100001).ToArray();
        for (int i = 0; i < list.Count(); i++) ans[list[i]] = 1;
        for (int i = 0; i < 70; i++)
        {
            for (int j = 0; j <= 100001; j++)
            {
                for (int k = 0; k < list.Count(); k++)
                {
                    if (j + list[k] < 100001 && ans[j + list[k]] > ans[j]) ans[j + list[k]] = ans[j] + 1;
                }
            }
        }
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(ans[n]);
    }
}
