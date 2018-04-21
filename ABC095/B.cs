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
            var nx = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var list = new List<int>();
            for(int i = 0; i<nx[0];i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            int ans = list.Count();
            nx[1] -= list.Sum();
            while(nx[1] >= list.Min())
            {
                nx[1] -= list.Min();
                ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
