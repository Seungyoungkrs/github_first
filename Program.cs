// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        GreetUser();
    }

    static void GreetUser()
    {
        Console.Write("당신의 이름을 입력하세요: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nave))
        {
            Console.WriteLine("이름 입력 없음");
        }
        else
        {
            Console.WriteLine("이름 입력됨");
        }
        
        Console.WriteLine($"현재 시각은 {DateTime.Now} 입니다.")
    }
}
