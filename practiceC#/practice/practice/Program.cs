using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Администрирование кафе: \n");
            
            bool isOpen = true;
            
            Table[] tables = { new Table(1, 4), new Table(2, 8), new Table(3, 10) };

            //Делаю переменную открытия окна для отслеживания состояния столов, создаю массив объектов столов

            while (isOpen)
            {
                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                Console.WriteLine("\nВведите номер стола: ");
                int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("\nВведите количество мест для брони: ");
                int desiredPlaces = Convert.ToInt32(Console.ReadLine());

                bool isReservationCompleted = tables[wishTable].Reserve(desiredPlaces);

                if (isReservationCompleted)
                {
                    Console.WriteLine("Бронь прошла успешно!");
                }
                else
                {
                    Console.WriteLine("Бронь не прошла. Не хватает мест");
                }

                Console.ReadKey();
                Console.Clear();
            }
            //Сделал через бесконечный цикл вайл постоянно открытую консоль которая в итоге считывает от пользователя ввод и обновляется. Для пользователя видно количество столов и их мест.
                //Пользователь вводит номер стола и сколько ему мест нужно, далее делаю переменную которая выдает:true если есть нужные свободные места и в обратном случае если нет свободных мест.
                //Далее через условие даю пользователю понять прошла бронь или нет.

        }
    }
    
    
    class Table
    {
        public int Number;
        public int MaxPlaces;
        public int FreePlaces;

        public Table(int number, int maxPlaces)
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Стол: {Number}. Свободно мест: {FreePlaces} из {MaxPlaces}");
        }

        public bool Reserve(int places)
        {
            if (FreePlaces >= places)
            {
                FreePlaces -= places;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    //Создал класс Стол, у которого есть следующие параметры: номер стола, на какое количество людей расчитан стол, свободные места за которыми могут сидеть людщи. Далее сделал конструктор класса.
        //Сделал метод который показывает нужную информацию о столике и метод который позволяет бронировать стол.
        
    //В итоге сделал закрепление материала, с косвенным использованием инкапсуляции и вполне полным использованием абстракции, т.к. вполне я мог в класс Talbe добавить поля характеристики стола по типу материала
        //   из которого сделан стол, кол-во ножек у него и т.п.
}
