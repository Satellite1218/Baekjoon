using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = int.Parse(a);
            int cnt = n, c = 1;
            for(int i = 0; i < n; i++)
            {
                for (int j = cnt - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < c; k++)
                {
                    Console.Write("*");
                }
                cnt--;
                c++;
                Console.WriteLine();
            }
        }
    }
}