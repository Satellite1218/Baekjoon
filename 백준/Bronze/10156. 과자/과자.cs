using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split(' ');
            int a = int.Parse(n[0]);
            int b = int.Parse(n[1]);
            int c = int.Parse(n[2]);

            int max = a * b;
            if (max - c < 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(max - c);
            }
        }
    }
}
