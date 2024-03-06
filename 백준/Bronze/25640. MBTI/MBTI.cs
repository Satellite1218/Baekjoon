using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mbti = Console.ReadLine();
            string n = Console.ReadLine();
            int a = int.Parse(n);
            int cnt = 0;
            for (int i = 0; i < a; i++)
            {
                string s = Console.ReadLine();
                if (s == mbti)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}