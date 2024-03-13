using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');

            int c = int.Parse(a[0]);
            int m = int.Parse(a[1]);

            if (m < 45)
            {
                if (c == 0)
                {
                    c = 23;
                }
                else
                {
                    c--;
                }
                m += 60;
            }
            Console.WriteLine("{0} {1}", c, m - 45);
        }
    }
}