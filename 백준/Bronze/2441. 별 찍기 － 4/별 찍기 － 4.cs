using System;
namespace ConsoleApplication1
{
    class Program
    {   
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = int.Parse(a);
            int cnt = n;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < cnt; k++)
                {
                    Console.Write("*");
                }
                cnt--;
                Console.WriteLine();
            }
        }
    }
}