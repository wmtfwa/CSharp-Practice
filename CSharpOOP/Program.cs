using System;

namespace CSharpOOP
{
    // 객체 (OOP Object Oriented Programming)

    // knight

    // 속성 : hp, attack, pos
    // 기능 : Move, Attack, Die

    class Knight
    {
        public int hp;
        public int attack;

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    // class : 참조, ref
    // struct : 복사

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();

            knight.hp = 100;
            knight.attack = 10;

            knight.Move();
            knight.Attack();

            Knight knight2 = knight.Clone();
            knight2.hp = 90;
        }
    }
}
