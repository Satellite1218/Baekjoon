using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 정수의 개수 N 입력 받기
        int N = int.Parse(Console.ReadLine());
        
        // N개의 정수를 공백으로 구분하여 입력 받기
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        // 최솟값과 최댓값 찾기
        int min = numbers.Min();
        int max = numbers.Max();
        
        // 결과 출력
        Console.WriteLine($"{min} {max}");
    }
}
