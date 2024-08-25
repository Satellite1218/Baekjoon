using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tr1, tr2, tr3, tr4, tr5, tr6, tr7;
            tr1 = "Never gonna give you up";
            tr2 = "Never gonna let you down";
            tr3 = "Never gonna run around and desert you";
            tr4 = "Never gonna make you cry";
            tr5 = "Never gonna say goodbye";
            tr6 = "Never gonna tell a lie and hurt you";
            tr7 = "Never gonna stop";
            string input;
            int hack = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                if (input != tr1 && input != tr2 && input != tr3 && input != tr4 && input != tr5 && input != tr6 && input != tr7)
                {
                    hack++;
                }
            }
            if (hack == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}