using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int a = int.Parse(n);
            int x = 0, y = 0;
            for (int i = 0; i < a; i++)
            {
                string[] s = Console.ReadLine().Split(',');
                x = int.Parse(s[0]);
                y = int.Parse(s[1]);
                Console.WriteLine(x + y);
            }
        }
    }
}
