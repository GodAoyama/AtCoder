using System;
using System.Linq;

namespace AtCoder
{
    class Program
    {
        static void Main()
        {
            var nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var p = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var par = new int[nm[0] + 1];
            for (int i = 0; i < par.Count(); i++) par[i] = i;
            for (int i = 0; i < nm[1]; i++) MakeEdge(ref par);

            int ans = 0;
            for (int i = 0; i < nm[0]; i++) if (FindRoot(par, p[i]) == FindRoot(par, p[p[i] - 1])) ans++;
            Console.WriteLine(ans);
        }

        static void MakeEdge(ref int[] par)
        {
            var inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int v1 = inp.Max();
            int v2 = inp.Min();
            while (par[v2] != v2) v2 = par[v2];
            while (par[v1] != v1)
            {
                int temp = v1;
                v1 = par[v1];
                par[temp] = v2;
            }
            par[v1] = v2;
        }

        static int FindRoot(int[] par, int x)
        {
            while (par[x] != x) x = par[x];
            return x;
        }
    }
}
