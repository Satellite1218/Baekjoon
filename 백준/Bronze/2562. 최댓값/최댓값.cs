using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, stack = 0;
            for (int i = 1; i <= 9; i++)
            {
                string a = Console.ReadLine();
                int n = int.Parse(a);

                if(n > max)
                {
                    max = n;
                    stack = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(stack);
        }
    }
}
