using System;

namespace CSharpLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // while 반목문
            int count = 5;

            while (count > 0)
            {
                Console.WriteLine("Hello World");
                count--;
            }


            string answer;

            // 무조건 한번 실행 후 조건 확인
            do
            {
                Console.WriteLine("PRESS y/n");
                answer = Console.ReadLine();
            } while (answer != "y");

            // for(초기화식; 조건식; 반복식;)
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello For");
            }


            // break, continue

            // 소수 판별
            int num = 98;

            bool isPrime = true;

            for(int i = 2; i< num; i++)
            {
                if((num % i) == 0)
                {
                    isPrime = false;
                    Console.WriteLine("소수가 아님");
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine("소수임");
            else
                Console.WriteLine("소수아님");


            for(int i = 1; i<=100; i++)
            {
                if ((i % 3) != 0)
                    continue;

                Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
            }
        }
    }
}
