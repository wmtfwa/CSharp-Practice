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
        }
    }
}
