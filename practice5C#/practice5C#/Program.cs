using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice5C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fighterNumber;
            
            //Инициализирую переменную в который будет записываться выбор бойца пользователем

            Fighter[] fighters =
            {
                new Fighter("Джон",500,50,0),
                new Fighter("Марк",250,25,20),
                new Fighter("Алекс",150,100,10),
                new Fighter("Джек",300,75,5)
            };

            //Вручную делаю список объектов(бойцов)

            for (int i = 0; i < fighters.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                fighters[i].ShowStatus();
            }

            //Через цикл показываю пользователю какие имеются бойцы и их характеристики

            Console.WriteLine("\n** " + new string('-', 25) + " **");
            Console.Write($"\nВыберите номер первого бойца: ");
            fighterNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            Fighter firstFighter = fighters[fighterNumber];

            Console.Write($"\nВыберите номер второго бойца: ");
            fighterNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            Fighter secondFighter = fighters[fighterNumber];
            Console.WriteLine("\n** " + new string('-', 25) + " **");

            //Фиксирую выборы пользователя и присваиваю их к переменным первыйБоец и второйБоец

            while (firstFighter.Health > 0 && secondFighter.Health > 0)
            {
                firstFighter.TakeDamage(secondFighter.Damage);
                secondFighter.TakeDamage(firstFighter.Damage);
                firstFighter.ShowCurrentHealth();
                secondFighter.ShowCurrentHealth();

                if (firstFighter.Health <= 0 && secondFighter.Health <= 0)
                {
                    Console.WriteLine($"У нас НИЧЬЯ!!!");
                }
                else if (firstFighter.Health <= 0 && secondFighter.Health > 0)
                {
                    Console.WriteLine($"У нас победитель, это: {secondFighter.Name}");
                }
                else if (firstFighter.Health > 0 && secondFighter.Health <= 0)
                {
                    Console.WriteLine($"У нас победитель, это: {firstFighter.Name}");
                }

                //Провожу бой через цикл вайл который будет работать до того момента пока у обоих бойцов кол-ва здоровья больше 0. Через метод TakeDamage какждый боец делает по удару, после чего говорю о кол-ве здоровья бойцов
                //После чего сравниваю здоровья, чтобы проверить не одержал ли победу кто-то либо же оба бойца мертвы и между ними ничья
            }
        }
    }

    class Fighter
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;

        //Абстрагируемся от кучи свойств которые могли быть присуще бойцу в поединке и оставляем лишь нужные нам в рамках боя

        public int Health
        {
            get { return _health; }
        }

        public int Damage
        {
            get { return _damage; }
        }

        public string Name
        {
            get { return _name; }
        }

        //Делаем 3 метода позволяющие нам получать значения здоровья, урона и имени объекта(бойца)


        public Fighter (string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        //Конструктор

        public void ShowStatus()
        {
            Console.WriteLine($"Боец - {_name}, здоровье: {_health}, наносимый" +
                $" урон: {_damage}, броня: {_armor}");
        }

        //Метод для того чтобы показывать пользователю информацию о бойце

        public void ShowCurrentHealth()
        {
            Console.WriteLine($"{_name} здоровье: {_health}");
        }

        //Метод который выводит сколько здоровья остальнось у бойца

        public void TakeDamage(int damage)
        {
            _health -= damage - _armor;
        }

        //Метод которые позволяет бойцу принимать урон от его противника
    }
}
