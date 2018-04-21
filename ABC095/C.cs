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
            var inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = inp[0];
            int b = inp[1];
            int c = inp[2];
            int x = inp[3];
            int y = inp[4];

            bool buyAB = false;            
            if (a + b > 2 * c) buyAB = true;

            int ans = 0;
            int ansOver = Math.Max(x, y) * c * 2;
            if (buyAB)
            {
                while (x > 0 && y > 0)
                {
                    x--;
                    y--;
                    ans += c * 2;
                }
            }
            ans = ans + a * x + b * y;
            Console.WriteLine(Math.Min(ans,ansOver));
        }
    }
}
