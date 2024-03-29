using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int a = int.Parse(n);
            int x = 0, y = 0;
            int Q1 = 0, Q2 = 0, Q3 = 0, Q4 = 0, AXIS = 0;
            for (int i = 0; i < a; i++)
            {
                string[] s = Console.ReadLine().Split();
                x = int.Parse(s[0]);
                y = int.Parse(s[1]);
                if (x > 0 && y > 0)
                {
                    Q1++;
                }
                else if (x < 0 && y > 0)
                {
                    Q2++;
                }
                else if(x < 0 && y < 0)
                {
                    Q3++;
                }
                else if(x > 0 && y < 0)
                {
                    Q4++;
                }
                else
                {
                    AXIS++;
                }
            }
            Console.WriteLine("Q1: " + Q1);
            Console.WriteLine("Q2: " + Q2);
            Console.WriteLine("Q3: " + Q3);
            Console.WriteLine("Q4: " + Q4);
            Console.WriteLine("AXIS: " + AXIS);
        }
    }
}
