using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string one = b.Substring(2).Trim();
            string ten = b.Substring(1, a.Length - 2).Trim();
            string hun = b.Substring(0, a.Length - 2).Trim();

            int cnt = int.Parse(a) * int.Parse(b);
            int arr = int.Parse(a);

            Console.WriteLine(arr * int.Parse(one));
            Console.WriteLine(arr * int.Parse(ten));
            Console.WriteLine(arr * int.Parse(hun));
            Console.WriteLine(cnt);
        }
    }
}