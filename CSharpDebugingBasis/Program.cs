using System;

namespace CSharpDebugingBasis
{
    //  메소드 호출 -> inception

    class Program
    {
        // 한 단계씩 코드 실행 F11
        // 프로시저 단위 실행 F10

        static void Print(int value)
        {
            Console.WriteLine(value);
        }
        static int AddandPrint(int a, int b)
        {
            int ret = a + b;
            Print(ret);
            return ret;
        }
        static void Main(string[] args)
        {
            int ret = AddandPrint(10, 20);
        }
    }
}
