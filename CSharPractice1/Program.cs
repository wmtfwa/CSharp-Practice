using System;

namespace CSharPractice1
{
    class Program
    {
        static int Factorial(int n)
        {
            int result = 1;
            for(int i = 1; i <= 5; i++)
            {
                result *= i;
            }
            return result;
        }

        static int Factorial1(int n)
        {
            if (n <= 1)
                return 1;
            return n * Factorial1(n - 1);
        }

        static void Main(string[] args)
        {
            // 구구단
            //for(int i = 2; i < 10; i++)
            //{
            //    for(int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }
            //}

            // 별찍기
            //for(int i = 0; i <= 4; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // 팩토리얼
            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}
