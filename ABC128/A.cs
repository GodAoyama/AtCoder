using System;
class c
{
    static void Main()
    {
        var ap = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine((ap[0] * 3 + ap[1]) / 2);
    }
}
