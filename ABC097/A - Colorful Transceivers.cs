using System;
namespace AtCoder
{
    class Program
    {
        static void Main()
        {
            var inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(Math.Abs(inp[2] - inp[0]) <= inp[3] || (Math.Abs(inp[1] - inp[0]) <= inp[3] && Math.Abs(inp[2] - inp[1]) <= inp[3]) ? "Yes" : "No");
        }
    }
}
