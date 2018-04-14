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
            double mid = a.Max() / 2.0;
            double temp = double.MaxValue;
            int ans = -1;
            for(int i = n-1; i >= 0; i--)
            {
                if(Math.Abs(a[i] - mid) < temp)
                {
                    temp = Math.Abs(a[i] - mid);
                    ans = a[i];
                }
            }
            Console.WriteLine("{0} {1}",a.Max(),ans);
        }
    }
}
