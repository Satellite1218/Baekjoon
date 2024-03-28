using System;
using System.Xml.Linq;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = int.Parse(a);
            
            for(int i = 1; i < 10; i++) { 
                Console.WriteLine(n + " * " + i + " = " + n*i);
            }
        }
    }
}