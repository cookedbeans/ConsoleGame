using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)

        {
            Random rnd = new Random();

            Robot user = new Robot(2, 12, 3);
            Robot pc = new Robot(1, 13, 3);

            Console.WriteLine("Давайте сыграем! Ваша задача выжить и убить противника.");
            Console.WriteLine("Показатель здоровья вашего робота: {0}", user.hp);
            Console.WriteLine("Показатель здоровья робота противника: {0}", pc.hp);
            Console.WriteLine("____________Начинаем!____________");


            while (user.hp > 0 & pc.hp > 0)
            {
                Console.Write("Что будете делать? \n 1. Выстрел \n 2. Исцеление \n");

                string move = Console.ReadLine();

                switch (move)
                {
                    case "1":
                        user.Shot(pc);
                        break;
                    case "2":
                        user.Heal();
                        break;
                    default:
                        Console.WriteLine("Команда введена неверно! Попробуйте еще раз.");
                        continue;

                }

                if (pc.hp < 0) break;

                int move_1 = rnd.Next(1, 3);

                switch (move_1)
                {
                    case 1:
                        pc.Shot(user);
                        Console.WriteLine("Противник стреляет!!!");
                        break;
                    case 2:
                        pc.Heal();
                        Console.WriteLine("Противник восстанавливает здоровье.");
                        break;
                }

                Console.WriteLine("___________________________");
                Console.WriteLine("| Ваши  показатели |   Очки здоровья: {0}  ", user.hp, user);
                Console.WriteLine("| Показатели врага |   Очки здоровья: {0} \n", pc.hp);


            }


            if (user.hp <= 0) Console.WriteLine("Поражение! Противник оказался сильнее...");
            else if (pc.hp <= 0) Console.WriteLine("Вы устранили противника! Победа!");

        }
    }
}

