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
            var nmx = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(a);
            var b = a.TakeWhile(i => i < nmx[2]);
            Console.WriteLine(Math.Min(b.Count(),nmx[1]-b.Count()));
        }
    }
}
