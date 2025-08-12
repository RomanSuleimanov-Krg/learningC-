using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight warrior1 = new Knight(100, 5, 25);
            Barbarian warrior2 = new Barbarian(100, 4, 20);

            warrior1.TakeDamage(25);
            warrior2.TakeDamage(35);

            Console.WriteLine($"Рыцарь:");
            warrior1.ShowInfo();

            Console.WriteLine($"\nВарвар:");
            warrior2.ShowInfo();


        }
    }

    class Warrior
    {
        protected int Health;
        protected int Armor;
        protected int Damage;

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public Warrior(int health, int armor, int damage)
        {
            Health = health;
            Armor = armor;
            Damage = damage;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Осталось = {Health} здоровья");
        }
    }

    class Knight : Warrior
    {

        public Knight(int health, int armor, int damage) : base(health, armor, damage)
        {

        }

        public void Pray()
        {
            Armor += 2;
        }


    }

    class Barbarian : Warrior
    {

        public Barbarian(int health, int armor, int damage) : base(health, armor, damage)
        {

        }

        public void Shout()
        {
            Armor -= 2;
            Health += 10;
        }
    }

}
