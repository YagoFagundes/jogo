using System;
using jogo.src.Entities;

namespace jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            hero Arus = new hero("Arus", "Knight", 23, 200, 200);
            hero Oponent = new hero("Maleficus", "Devil", 99, 1000, 2000);
            wizard Jennica = new wizard("Jennica", "Wizzard White", 23, 80, 120);
            knight Dark = new knight("Dark", "Knight", 50, 100, 100);
            ninja Jack = new ninja("Jack", "Ninja", 50, 80, 120);
            wizardBlack bruxo = new wizardBlack("Bruxo", "Wizzard Black", 50, 100, 100);

            Console.WriteLine($"BOSS {Oponent}");
            Console.WriteLine(Arus);
            Console.WriteLine(Arus.attack());
            Console.WriteLine(Arus.attack(10));
            Console.WriteLine(Jennica);
            Console.WriteLine(Jennica.attack());
            Console.WriteLine(Jennica.attack(15));
            Console.WriteLine(Dark);
            Console.WriteLine(Dark.attack());
            Console.WriteLine(Dark.attack(10));
            Console.WriteLine(Jack);
            Console.WriteLine(Jack.attack());
            Console.WriteLine(Jack.attack(10));
            Console.WriteLine(bruxo);
            Console.WriteLine(bruxo.attack());
            Console.WriteLine(bruxo.attack(10));
            Console.WriteLine($"O Oponente {Oponent.Name} Sofreu Ataques.");
            Console.WriteLine(Oponent.attack());
            Console.WriteLine(Oponent.attack(10));
        }
    }
}
