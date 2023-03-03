using System;

namespace CSharp
{
    class basic
    {
        static void Main(string[] args)
        {
            // byte(1바이트 0~255), short(2바이트 -3만~3만), int(4바이트 -21억~21억), long(8바이트)
            // sbyte(1바이트 -128~127), ushort(2바이트 0~6만), uint(4바이트 0~43억), ulong(8바이트)

            // 10진수

            // 2진수 - shift 연산, bit 연산 밀접한 관련
            // 0, 1
            // 0b - 이진수임을 표기하기 위함
            // 0b00 0b01 0b10 0b11 0b100

            // 16진수
            // 0~9 a b c d e f
            // 0x - 16진수임을 표기
            // 0x00 0x01 .... 0x0F
            // 0x10

            // 2진수에서 16진수로 - 4개씩 기준으로
            // 0b10001111 = 0x8F

            // 1바이트(참/거짓)
            bool b;
            b = true;
            b = false;

            // 실수
            // 4바이트
            float f = 3.14f;
            // 8바이트
            double d = 3.14;

            // 2바이트
            char c = 'a';

            string str = "sans";

            Console.WriteLine(str);

            // 형변환
            // 1. 크기가 다른 경우
            int a = 1000;
            short sa = (short)a;

            short sb = 100;
            int ab = sb;

            // 2. 크기는 값지만 부호가 다른 경우
            byte cb = 255;
            sbyte sc = (sbyte)cb;
            // underflow, overflow
            // 0xFF = 0b11111111 = -1

            // 3. 실수
            float flo = 3.1141f;
            double dou = flo;

            // Console.WriteLine("Hello World! {0}", hp);
        }
    }
}