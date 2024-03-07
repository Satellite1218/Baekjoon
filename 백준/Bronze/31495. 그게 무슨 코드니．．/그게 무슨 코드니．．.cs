using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            // 큰따옴표의 개수 확인
            int n = s.Split('"').Length - 1;

            // 큰따옴표가 2개 이하이고, 첫 번째와 마지막 문자가 큰따옴표인지 확인
            if (n <= 2 && s.Length >= 2 && s.StartsWith("\"") && s.EndsWith("\""))
            {
                // 큰따옴표 내부 문자열 추출
                string inn = s.Substring(1, s.Length - 2).Trim();

                // 큰따옴표 내부 문자열이 비어있는지 확인
                if (inn.Length > 0)
                {
                    Console.WriteLine(inn);
                }
                else
                {
                    Console.WriteLine("CE");
                }
            }
            else
            {
                Console.WriteLine("CE");
            }
        }
    }
}