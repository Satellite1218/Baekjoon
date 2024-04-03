using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, arr = 1;
            for (int i = 0; i < 10; i++)
            {
                string s = Console.ReadLine();
                a = int.Parse(s);
                if(a == 1)
                {
                    arr++;
                }
                else if(a == 2)
                {
                    arr += 2;
                }
                else if(a == 3)
                {
                    arr--;
                }

                if(arr > 4)
                {
                    arr -= 4;
                }
                else if (arr < 1)
                {
                    arr += 4;
                }
            }
            if (arr == 1)
            {
                Console.WriteLine("N");
            }
            else if(arr == 2)
            {
                Console.WriteLine("E");
            }
            else if(arr == 3)
            {
                Console.WriteLine("S");
            }
            else if(arr == 4)
            {
                Console.WriteLine("W");
            }
        }
    }
}
