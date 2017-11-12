using System;

class Program
{
    static void Main()
    {
        int val = 999;
        refMethod(ref val);
        Console.WriteLine(val);
        Console.ReadLine();
    }

    static void refMethod(ref int i)
    {
        i = 1;
        i = i + 1;
    }
}
