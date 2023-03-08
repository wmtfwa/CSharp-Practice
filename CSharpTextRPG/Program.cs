using System;

namespace CSharpTextRPG
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        // 구조체
        struct Player
        {
            public int hp;
            public int attack;
        }

        static ClassType ChooseClass()
        {
            Console.WriteLine("직업 선택");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            ClassType choice = ClassType.None;

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }
            return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            // 기사(100/10) 궁수(75/14) 법사 (50/18)
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 14;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 18;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                {
                    // 캐릭터 생성
                    Player player;

                    CreatePlayer(choice, out player);

                    Console.WriteLine($"HP : {player.hp}  Attack : {player.attack}");
                    
                    // 사냥
                }
            }
        }
    }
}
