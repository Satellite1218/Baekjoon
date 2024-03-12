using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(n[0]) - int.Parse(n[1]));
        }
    }
}