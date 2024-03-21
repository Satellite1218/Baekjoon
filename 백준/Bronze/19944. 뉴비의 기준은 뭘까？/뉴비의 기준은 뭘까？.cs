using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split();
            int N = int.Parse(n[0]); // N학년 이하
            int M = int.Parse(n[1]); // M학년 학생
            
            if (M == 1 || M == 2) // 뉴비 조건
            {
                Console.WriteLine("NEWBIE!");
            }
            else if (M <= N) // 올드비 조건 (N학년 이하이면서 뉴비가 아닌 경우)
            {
                Console.WriteLine("OLDBIE!");
            }
            else // TLE 조건 (뉴비도 아니고 올드비도 아닌 경우)
            {
                Console.WriteLine("TLE!");
            }
        }
    }
}
