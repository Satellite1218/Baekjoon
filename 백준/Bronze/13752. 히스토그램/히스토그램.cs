using System;
using System.Xml.Linq;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int a = int.Parse(n);
            int[] cnt = new int[100];

            for (int i = 0; i < a; i++)
            {
                string s = Console.ReadLine();
                cnt[i] = int.Parse(s);
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < cnt[i]; j++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
            }
        }
    }
}