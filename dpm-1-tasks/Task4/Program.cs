using System;
class Task4
{
    static void Main()
    {
        Console.WriteLine("a =");int a  = int.Parse(Console.ReadLine());

        Console.WriteLine(a += 5);
        Console.WriteLine(a -= 5);
        Console.WriteLine(a *= 5);
        Console.WriteLine(a /= 5);
        Console.WriteLine(a %= 5);
    }
}
