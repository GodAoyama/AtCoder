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
            string s = Console.ReadLine();
            int x = s.ToCharArray().Count(c => c == 'o');
            Console.WriteLine(700 + x * 100);
        }
    }
}
