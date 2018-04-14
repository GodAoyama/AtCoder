using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse).ToList();
            var b = a.OrderBy(x => x).ToList();
            int low = b[n / 2 - 1];
            int high = b[n / 2];
            for(int i = 0; i < n; i++)
            {
                if (a[i] < high) Console.WriteLine(high);
                else Console.WriteLine(low);
            }
        }
    }
}
