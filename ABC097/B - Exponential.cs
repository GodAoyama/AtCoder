using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 1; i <= 40; i++)
                for (int j = 2; j <= 10; j++)
                    list.Add((int)Math.Pow(i, j));
            Console.WriteLine(list.Where(x => x <= n && x > 0).Max());
        }
    }
}
