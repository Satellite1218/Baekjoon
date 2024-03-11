using System;
using System.Xml.Linq;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int n = int.Parse(a[0]); // 문제 후보
            int m = int.Parse(a[1]); // 출제위원

            int count = 0; //찬성한 문제

            for (int i = 0; i < n; i++)
            {
                string opinions = Console.ReadLine(); // 출제위원의 찬반 의견
                int cnt = 0; // 찬성 표

                foreach (char opinion in opinions)
                {
                    if (opinion == 'O')
                    {
                        cnt++;
                    }
                }

                if (cnt > m / 2)
                {
                    count++;
                }
            }

            Console.WriteLine(count); // 출제될 문제의 수 출력
        }
    }
}