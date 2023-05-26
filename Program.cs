using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniePKS_20BUZIN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            String firstword = "Hello ";
            String secondword = "world";
            Console.WriteLine(firstword + secondword);


            //Задание 2
            int firstvalue = 1;
            int secondvalue = 1;
            Console.WriteLine(firstvalue + secondvalue);
            Console.WriteLine(firstvalue - secondvalue);
            Console.WriteLine(firstvalue * secondvalue);
            Console.WriteLine(firstvalue / secondvalue);

            //Задание 3
            Console.Write("Введите имя: ");
            String name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            String secondname = Console.ReadLine();
            Console.Write("Введите отчество: ");
            String otchestvo = Console.ReadLine();
            Console.WriteLine(name + " " + secondname + " " + otchestvo);

            //Задание 4
            Console.WriteLine("Введите здоровье, атаку и защиту героя: ");
            int healthHero = Convert.ToInt32(Console.ReadLine());
            int attackHero = Convert.ToInt32(Console.ReadLine());
            int defenceHero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите здоровье, атаку и защиту противника: ");
            int healthEnemy = Convert.ToInt32(Console.ReadLine());
            int attackEnemy = Convert.ToInt32(Console.ReadLine());
            int defenceEnemy = Convert.ToInt32(Console.ReadLine());

            healthHero = attackEnemy / defenceHero;
            healthEnemy = attackHero / defenceEnemy;

            int damageDealHero = attackHero - defenceEnemy;
            int damageDealEnemy = attackEnemy - defenceHero;

            Console.WriteLine("У игрока осталось: " + healthHero + " здоровья.");
            Console.WriteLine("У противника осталось: " + healthEnemy + " здоровья.");
            Console.WriteLine("Игрок нанес: " + damageDealHero + " урона.");
            Console.WriteLine("Противник нанес: " + damageDealEnemy + " урона.");

            Console.ReadKey();
        }
    }
}