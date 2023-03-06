using System;

namespace CSharpFlowControl
{
    class Flow
    {
        enum eChoice
        {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }
        static void Main(string[] args)
        {
            //// 분기문
            ////int hp1 = 100;
            ////bool isDead = (hp1 <= 0);

            ////if(isDead)
            ////{
            ////    Console.WriteLine("Dead");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Alive");
            ////}

            //int choice = 0; // 0:가위 1:바위 2:보

            //if (choice == 0)
            //    Console.WriteLine("가위");
            //else if (choice == 1)
            //    Console.WriteLine("바위");
            //else if (choice == 2)
            //    Console.WriteLine("보");
            //else
            //    Console.WriteLine("치트키");

            //switch(choice)
            //{
            //    case 0:
            //        Console.WriteLine("가위");
            //        break;
            //    case 1:
            //        Console.WriteLine("바위");
            //        break;
            //    case 2:
            //        Console.WriteLine("보");
            //        break;
            //    case 3:
            //        Console.WriteLine("치트키");
            //        break;
            //    default:
            //        Console.WriteLine("실패");
            //        break;
            //}

            //// 삼항 연산자

            //int number = 25;

            //bool isPair;

            ////if ((number % 2) == 0)
            ////    isPair = true;
            ////else
            ////    isPair = false;

            //// bool isPair = (조건 ? 맞을때 : 틀릴때);

            //isPair = ((number % 2) == 0 ? true : false);


            // 가위바위보 게임
            // 0:가위 1:바위 2:보

            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 0;

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); // 0~2 사이의 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                // 위에 enum 열거형 만들어놓음
                case (int)eChoice.Scissors:
                    Console.WriteLine("사용자 : 가위");
                    break;
                case ROCK:
                    Console.WriteLine("사용자 : 바위");
                    break;
                case PAPER:
                    Console.WriteLine("사용자 : 보");
                    break;
            }
            switch (aiChoice)
            {
                case SCISSORS:
                    Console.WriteLine("AI : 가위");
                    break;
                case ROCK:
                    Console.WriteLine("AI : 바위");
                    break;
                case PAPER:
                    Console.WriteLine("AI : 보");
                    break;
            }

            // 승리 무승부 패배
            if (choice == aiChoice)
            {
                Console.WriteLine("무승부");
            }
            else if (choice == SCISSORS && aiChoice == PAPER)
            {
                Console.WriteLine("승리");
            }
            else if (choice == ROCK && aiChoice == SCISSORS)
            {
                Console.WriteLine("승리");
            }
            else if (choice == PAPER && aiChoice == ROCK)
            {
                Console.WriteLine("승리");
            }
            else
            {
                Console.WriteLine("패배");
            }
        }
    }
}
