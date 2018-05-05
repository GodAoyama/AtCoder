using System;

namespace AtCoder
{
    class Program
    {
        static void Main()
        {
            var hw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string[] map = new string[hw[0]];
            for (int i = 0; i < hw[0]; i++)
            {
                map[i] = Console.ReadLine();
            }

            bool ans = true;
            for (int i = 0; i < hw[0]; i++)
            {
                for (int j = 0; j < hw[1]; j++)
                {
                    if (map[i][j] == '#')
                    {
                        if (i - 1 >= 0 && map[i - 1][j] == '#') continue;
                        if (j - 1 >= 0 && map[i][j - 1] == '#') continue;
                        if (i + 1 < hw[0] && map[i + 1][j] == '#') continue;
                        if (j + 1 < hw[1] && map[i][j + 1] == '#') continue;
                        ans = false;
                    }
                }
            }
            Console.WriteLine(ans ? "Yes" : "No");
        }
    }
}
