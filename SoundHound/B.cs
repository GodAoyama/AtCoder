using System;
class Program
{
    static void Main()
    {
        var s = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        var ans = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            if (i % n == 0) ans += s[i];
        }
        Console.WriteLine(ans);
    }
}
