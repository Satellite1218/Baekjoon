using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int Q = 25, D = 10, N = 5, P = 1;
            int q = 0, d = 0, n = 0, p = 0;
            for (int i = 0; i < a; i++)
            {
                int c = int.Parse(Console.ReadLine());
                while (c > 0)
                {
                    if(0 <= c - Q)
                    {
                        c -= Q;
                        q++;
                    }
                    else if(0 <= c - D)
                    {
                        c-= D;
                        d++;
                    }
                    else if (0 <= c - N)
                    {
                        c -= N;
                        n++;
                    }
                    else if (0 <= c - P)
                    {
                        c -= P;
                        p++;
                    }
                }
                Console.WriteLine("{0} {1} {2} {3}", q, d, n, p);
                q = 0; d = 0; n = 0; p = 0;
            }
        }
    }
}