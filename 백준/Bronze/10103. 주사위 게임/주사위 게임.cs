    using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int ti = int.Parse(t);
            int a, b;
            int sca = 100, scb = 100;
            for (int i = 0; i < ti; i++)
            {
                string[] n = Console.ReadLine().Split();
                a = int.Parse(n[0]);
                b = int.Parse(n[1]);
                if(a > b)
                {
                    scb -= a;
                }
                else if (b > a)
                {
                    sca -= b;
                }
            }
            Console.WriteLine(sca);
            Console.WriteLine(scb);
        }
    }
}