using System;
using System.Linq;

namespace AtCoder
{
    class Program
    {
        static void Main()
        {
            var inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                inp = inp.OrderByDescending(x => x).ToArray();
                inp[0] *= 2;
            }
            Console.WriteLine(inp.Sum());
        }
    }
}
