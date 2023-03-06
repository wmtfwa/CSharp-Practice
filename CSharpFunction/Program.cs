using System;

namespace CSharpFunction
{
    class Program
    {
        // Method Function Procedure
        // 한정자 반환형식 이름(매개변수목록)
        static void HelloWorld()
        {
            Console.WriteLine("HelloWorld");
        }


        // 복사, 참조의 차이
        // ref 가 있으면 참조, 없으면 복사
        static void AddOne(ref int number)
        {
            number = number + 1;
        }

        static int AddOne2(int number)
        {
            return number + 1;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // out 참조
        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }

        // 덧셈 함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        // 오버로딩
        // 함수 이름의 재사용
        static int Add(int a, int b, int c = 0)
        {
            return a + b + c;
        }

        static float Add(float a, float b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            HelloWorld();

            int result = Add(4, 5);
            Console.WriteLine(result);

            int a = 0;
            // ref 참조
            // 복사(가짜) 참조(진짜)
            AddOne(ref a);
            Console.WriteLine(a);

            // 이 방법이 선호됨
            a = AddOne2(a);
            Console.WriteLine(a);

            int num1 = 1;
            int num2 = 2;
            Swap(ref num1, ref num2);

            int n1 = 10;
            int n2 = 3;

            int result1;
            int result2;

            Divide(n1, n2, out result1, out result2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);


            // 오버로딩
            Console.WriteLine("오버로딩");
            int ret1 = Add(2, 3);
            float ret2 = Add(2.0f, 3.0f);
        }
    }
}
