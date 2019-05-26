using System;
using System.Linq;
using System.Collections.Generic;
class c
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var list = new List<Tuple<string, int, int>>();
        for (int i = 0; i < n; i++)
        {
            var s = Console.ReadLine();
            var line = s.Split(' ');
            list.Add(new Tuple<string, int, int>(line[0], int.Parse(line[1]), i + 1));
        }
        list = list.OrderBy(f => f.Item1).ThenByDescending(f => f.Item2).ToList();
        foreach (var x in list) Console.WriteLine(x.Item3);
    }
}
