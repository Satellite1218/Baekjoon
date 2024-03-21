using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split();
            int w = int.Parse(n[0]);
            int h = int.Parse(n[1]);
            float a = w * h;

            if (a / 2 == w * h / 2)
            {
                Console.WriteLine(a / 2 + ".0");
            }
            else
            {
                Console.WriteLine(a / 2);
            }
        }
    }
}
