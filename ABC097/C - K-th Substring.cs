using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());
        var subsList = new List<string>();
        var charList = new List<char>();
        for (int i = 0; i < s.Length; i++) charList.Add(s[i]);
        charList = charList.Distinct().OrderBy(c => c).ToList();

        for (int x = 0; x < charList.Count(); x++)
        {
            subsList.Add(charList[x].ToString());
            if (subsList.Count > k) break;
            for (int i = 1; i <= 4; i++)
                for (int j = 0; j < s.Length - i; j++)
                    if (s[j] == charList[x]) subsList.Add(s.Substring(j, i + 1));
            subsList = subsList.Distinct().ToList();
        }
        Console.WriteLine(subsList.OrderBy(x => x).Where((x, y) => y == k - 1).First());
    }
}
