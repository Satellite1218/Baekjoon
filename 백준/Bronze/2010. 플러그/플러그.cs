    using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = int.Parse(a);
            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                cnt += int.Parse(s);
            }
            Console.WriteLine(cnt - n + 1);
        }
    }
}