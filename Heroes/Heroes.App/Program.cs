using Heroes.Lib.Races;
using Heroes.Lib.Weapons;
using System;
namespace Heroes.App
{
    public static class Program
    {
        public enum TypeHero
        {
            Numan,
            Elf,
            Unknown
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Тип персонажа:");
            Console.WriteLine("1. Человек (бонус к атаке)");
            Console.WriteLine("2. Эльф (бонус к здоровью)");
            Console.Write("Введите номер персонажа : ");
            var select = Console.ReadLine();
            Console.Write("Введите имя : ");
            string name = Console.ReadLine();
            TypeHero typeHero;
            TypeHero typeEnemy;
            switch (select)
            {
                case "1":
                    typeHero = TypeHero.Numan;
                    typeEnemy = TypeHero.Elf;
                    break;
                case "2":
                    typeHero = TypeHero.Elf;
                    typeEnemy = TypeHero.Numan;
                    break;
                default:
                    typeHero = TypeHero.Unknown;
                    typeEnemy = TypeHero.Unknown;
                    break;

            }
            Race hero = CreateHero(typeHero, name);
            Race enemy = CreateHero(typeEnemy, "enemy");

            ShowHeroInfo(hero);
            ShowHeroInfo(enemy);
            do
            {
                hero.Attack(enemy);
                Console.WriteLine($"{hero.Name} атакует {enemy.Name}");
                enemy.Attack(hero);
                Console.WriteLine($"{enemy.Name} атакует {hero.Name}");

                ShowHeroInfo(hero);
                ShowHeroInfo(enemy);


            } while (!hero.IsDeath && !enemy.IsDeath);
            if (hero.IsDeath)
            {
                Console.WriteLine($"{enemy.Name} Победил");
            }
            if (enemy.IsDeath)
            {
                Console.WriteLine($"{hero.Name} Победил");
            }
        }

        static Race CreateHero(TypeHero typeHero, string name) => typeHero switch
        {
            TypeHero.Numan => new Human(name, new Axe()),
            TypeHero.Elf => new Elf(name, new Axe()),
            _ => throw new ArgumentOutOfRangeException()
        };
        static void ShowHeroInfo(Race hero)
        {
            Console.WriteLine($"NAME:{hero.Name}, HEALTH:{hero.Health}");
        }
    }
}