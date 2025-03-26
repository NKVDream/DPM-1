using System;
namespace Project1
{
    class Task1
    {
        static void Main()
        {
            Console.WriteLine("write down your name: "); string name = Console.ReadLine();
            Console.WriteLine("write down your age: "); int age = int.Parse(Console.ReadLine());
            Console.WriteLine("write down your group: "); int group = int.Parse(Console.ReadLine());
            Console.WriteLine($"name: {name}\t age: {age}\t group: {group}");
        }
    }
}