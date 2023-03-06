using System;

namespace CSharpOperation
{
    class Operation
    {
        static void Main(string[] args)
        {
            int hp = 100;

            // + - * / %
            // hp = 100 * 2 + 1;

            hp++;
            // hp = hp + 1;
            hp--;
            // hp = hp - 1;
            ++hp;
            --hp;

            // 실행 순서 차이

            Console.WriteLine(hp++);

            int level = 50;

            // < <= > >= == !=
            // bool
            bool isAlive = (hp > 0);
            bool isHighLevel = (level >= 40);

            // && AND, || OR, ! NOT
            // a = 살아있는 40레벨 이상 유저인가요?
            bool a = isAlive && isHighLevel;

            // b = 살아있너나, 40레벨 이상이거나
            bool b = isAlive || isHighLevel;

            // c = 죽었는가
            bool c = !isAlive;


            // 비트 연산 - bit operation

            int num = 1;

            // << >> &(and) |(or) ^(xor) ~(not)
            num = num << 1;

            // 이진수에서의 칸이동
            Console.WriteLine(num);

            int id = 123;
            int key = 401;

            int aa = id ^ key;
            int bb = aa ^ key;

            Console.WriteLine(bb);

            // 연산우선순위
            // 1. ++ --
            // 2. * / %
            // 3. + -
            // 4. << >>
            // 5. < >
            // 6. == !=
            // 7. &
            // 8. ^
            // 9. |
            // ...

            // 우선순위가 헷갈릴때는 검색하거나 () 로 우선순위 강제하기

            // var - 형태를 자동으로 맞춰줌
            // 남용하지 않는게 좋음
            // 서로간에 코드를 해석하는데 힘듬
            // 비추
            // 명시적으로 표현해서 사용하는 것이 좋음
            var num1 = 3;
            var num2 = "Hello World";

        }
    }
}
