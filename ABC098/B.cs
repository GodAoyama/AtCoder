using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var s = Console.ReadLine();
        int ans = 0;
        for (int i = 0; i < s.Length; i++)
        {
            string X = s.Substring(i);
            string Y = s.Substring(0, i);
            int xy = 0;
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (X.Contains(c) && Y.Contains(c)) xy++;
            }
            ans = Math.Max(ans, xy);
        }
        Console.WriteLine(ans);
    }
}
