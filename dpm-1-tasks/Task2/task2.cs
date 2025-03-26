using System;
namespace Project2
{
    class Task2
    {
        static void Main()
        {
            Console.WriteLine("write down your name: "); string name = Console.ReadLine();
            Console.WriteLine("write down your age: "); int age = int.Parse(Console.ReadLine());
            Console.WriteLine("write down your group: "); int group = int.Parse(Console.ReadLine());
            Console.Write($"name: {name}\n age: {age}\n group: {group}");
        }
    }
}