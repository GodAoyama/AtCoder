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
            var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if(a[0] <= a[2] && a[0]+a[1] >= a[2])
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
        }
    }
}
