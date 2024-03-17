    using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2525 오븐시계
            string a = Console.ReadLine();
            int n = int.Parse(a);
            int cnt = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < cnt; j++)
                {
                    Console.Write("*");
                }
                cnt--;
                Console.WriteLine();
            }
        }
    }
}