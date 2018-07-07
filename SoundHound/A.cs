using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        if (ab.Sum() == 15) Console.WriteLine("+");
        else if (ab[0] * ab[1] == 15) Console.WriteLine("*");
        else Console.WriteLine("x");
    }
}
