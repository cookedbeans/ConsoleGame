using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Robot
    {
        public int armor, hp, damage;

        public Robot(int a, int b, int c) { armor = a; hp = b; damage = c; }

        public void GetInfo()
        {
            Console.WriteLine($"Броня: {armor}  Жизнь: {hp}  Урон: {damage}");
        }

        public void Shot(Robot def)
        {
            def.hp = def.hp - damage + def.armor;
        }

        public void Heal()
        {
            int n = 2;
            hp = hp + n;
        }
    }
}