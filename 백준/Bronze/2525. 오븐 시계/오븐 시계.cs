    using System;
    namespace ConsoleApplication1
    {
        class Program
        {   
            static void Main(string[] args)
            {
                //2525 오븐시계
                string[] a = Console.ReadLine().Split();
                int c = int.Parse(a[0]);
                int m = int.Parse(a[1]);
                string p = Console.ReadLine();
                int plus = int.Parse(p);

                while (plus >= 60)
                {
                    plus -= 60;
                    c++;
                    if (c >= 24)
                    {
                        c -= 24;
                    }
                }
                m += plus;
                if (m >= 60)
                {
                    m -= 60;
                    c++;
                    if (c >= 24)
                    {
                        c -= 24;
                    }
                }
                Console.WriteLine("{0} {1}", c, m);
            }
        }
    }