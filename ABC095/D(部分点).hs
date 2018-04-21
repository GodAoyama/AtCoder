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
            var nc = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            var dic = new Dictionary<long, long>();
            dic.Add(0, 0);
            for (int i = 0; i < nc[0]; i++)
            {
                var input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
                dic[input[0]] = input[1];
            }
            dic.Add(nc[1], 0);

            long[] x = dic.Keys.ToArray();
            long[] v = dic.Values.ToArray();

            long[] memoL = new long[nc[0] + 2];
            long[] memoR = new long[nc[0] + 2];
            long[] memoLR = new long[nc[0] + 2];
            long[] memoRL = new long[nc[0] + 2];

            for (int i = 1; i <= nc[0]; i++)
            {
                memoL[i] = memoL[i - 1] + v[i] - (x[i] - x[i - 1]);
            }
            for (int i = (int)nc[0]; i >= 1; i--)
            {
                memoR[i] = memoR[i + 1] + v[i] - (x[i + 1] - x[i]);
            }
            long maxL = memoL.Max();
            long maxR = memoR.Max();
            for (int i = 1; i <= nc[0] - 1; i++)
            {
                for (int j = (int)nc[0]; j >= i + 1; j--)
                {
                    long temp = memoL[i] + memoR[j] -  x[i];
                    memoLR[i] = Math.Max(memoLR[i], temp);
                }
            }
            for (int i = (int)nc[0]; i >= 2; i--)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    long temp = memoR[i] + memoL[j] - (nc[1] - x[i]);
                    memoRL[i] = Math.Max(memoRL[i], temp);
                }
            }
            long maxLR = memoLR.Max();
            long maxRL = memoRL.Max();
            long ans = Math.Max(Math.Max(maxL, maxR), Math.Max(maxLR, maxRL));
            Console.WriteLine(ans);
        }
    }
}
