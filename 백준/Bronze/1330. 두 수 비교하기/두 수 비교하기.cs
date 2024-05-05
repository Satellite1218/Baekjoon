using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            int n = int.Parse(a[0]);
            int m = int.Parse(a[1]);
            if (n < m)
            {
                Console.WriteLine("<");
            }
            else if (n > m)
            {
                Console.WriteLine(">");
            }
            else 
            {
                Console.WriteLine("==");
            }
        }
    }
}