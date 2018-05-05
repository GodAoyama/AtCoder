using System;

namespace AtCoder
{
    class Program
    {
        static void Main()
        {
            var inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(inp[0] <= inp[1] ? inp[0] : inp[0] - 1);
        }
    }
}
