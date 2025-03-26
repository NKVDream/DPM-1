using System;
class Task3
{
    static void Main()
    {
        Console.WriteLine("a = ");int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b = ");int b = int.Parse(Console.ReadLine());
        Console.WriteLine("c = ");int c = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int x = x = a-- + b * a++ + c;
        Console.WriteLine(x);
    }
}