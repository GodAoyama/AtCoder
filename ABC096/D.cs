using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var pList = new List<int>();
            pList.Add(2);
            pList.Add(3);
            bool isPrime = true;
            for (int i = 5; i < 55555; i += 2)
            {
                isPrime = true;
                for (int j = 3; j <= Math.Sqrt(i); j += 2)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) pList.Add(i);
            }
            var ans = new int[n];
            pList = pList.OrderByDescending(x => x).ToList();
            for (int i = 0; i < n; i++)
            {
                while(pList[0]%10 != 1)
                {
                    pList.RemoveAt(0);
                }
                ans[i] = pList[0];
                pList.RemoveAt(0);
            }
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}
