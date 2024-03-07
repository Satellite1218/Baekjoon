using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = Console.ReadLine();
            int cnt = int.Parse(c);
            for (int i = 0; i < cnt; i++)
            {
                string a = Console.ReadLine();
                int n = int.Parse(a);
                int next = n + 1;
                string inn = a.Substring(2).Trim();
                n = int.Parse(inn);

                if(next % n == 0)
                {
                    Console.WriteLine("Good");
                }
                else
                {
                    Console.WriteLine("Bye");
                }
            }
        }
    }
}