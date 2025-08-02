using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begin1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Логическое и  &&
            // Логическое или ||

            //int money = 500;
            //int level = 10;

            //if(money >= 500 || level > 9)
            //{
            //    Console.WriteLine("Проходи");
            //}
            //else
            //{
            //    Console.WriteLine("Не проходи");
            //}

            //string dayOfWeek;
            //dayOfWeek = Console.ReadLine();

            //switch (dayOfWeek)
            //{
            //    case "понедельник":
            //        Console.WriteLine("Идем в кино");
            //        break;

            //    case "вторник":
            //        Console.WriteLine("Не идем в кино");
            //        break;
            //    default:
            //        Console.WriteLine("Нет такого дня");
            //        break;

            //string password = "123qwe";
            //string userInput;

            //Console.Write("Введи пароль братуха: ");
            //userInput = Console.ReadLine();

            //if(userInput == password)
            //{
            //    Console.WriteLine("Вверно");
            //}
            //else
            //{
            //    Console.WriteLine("Не верно");
            //}

            //float rublesInWallet;
            //float dollarsInWallet;

            //int rubToUsd = 64, usdToRub = 66;

            //float exchangeCurrencyCount;

            //string desiredOperation;

            //Console.Write("Привет, введите баланс рублей: ");
            //rublesInWallet = Convert.ToSingle(Console.ReadLine());
            //Console.Write("Привет, введите баланс долларов: ");
            //dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Выберите операцию: ");
            //Console.Write("1 - обменять рубли в баксы;");
            //Console.Write(" 2 - обменять баксы в рубли");
            //Console.Write("; Сделайте ваш выбор: ");

            //desiredOperation = Console.ReadLine();

            //switch (desiredOperation)
            //{
            //    case "1":
            //        Console.WriteLine("Обмен рублей на доллары");
            //        Console.Write("Сколько рублей вы хотите обменять?: ");
            //        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
            //        if(rublesInWallet >= exchangeCurrencyCount)
            //        {
            //            rublesInWallet -= exchangeCurrencyCount;
            //            dollarsInWallet += exchangeCurrencyCount / rubToUsd;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Недоступное количество рублей");
            //        }
            //        break;
            //    case "2":
            //        Console.WriteLine("Обмен доллары на рубли");
            //        Console.Write("Сколько долларов вы хотите обменять?: ");
            //        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

            //        if(dollarsInWallet >= exchangeCurrencyCount)
            //        {
            //            dollarsInWallet -= exchangeCurrencyCount;
            //            rublesInWallet += exchangeCurrencyCount * usdToRub;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Недопустимое количество долларов");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Выбрана не верная операция");
            //        break;

            //}

            //Console.WriteLine($"Ваш баланс - {rublesInWallet} рублей" +
            //    $" и {dollarsInWallet} долларов");

            // Циклы

            //int age;

            //Console.Write("Введите ваш возраст: ");

            //age = Convert.ToInt32(Console.ReadLine());

            //while (age > 0)
            //{

            //    if (age > 20)
            //    {
            //        Console.WriteLine("Это дохуя братан");
            //        break;
            //    }
            //    Console.WriteLine("С др бро!");
            //    age -= 1;


            //* -------------[РАБОТА С КОНСОЛЬЮ]--------------

            //Console.WriteLine($"Текст 1\nТекст 2\nТекст 3");
            //* В месте постановки "\n" ставится перенос строки.

            //Console.WriteLine($"Привет!!!\b");
            //Console.Write($"Привет!!! \b\b");
            //* По умолчанию в cwl в конце стоит \n так что при
            //* одной \b убирается именно перенос строки

            //Console.SetCursorPosition(10, 10); 
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.Clear();
            //Console.WindowHeight = 50;
            //Console.WindowWidth = 150;

            //Console.WriteLine($"Приветики я просто текст в консольки");

            //* В общем все по переводу понятно. Позиция курсора, цвет фона и текста, очистка консоли, длина&ширина окна ну и текст в консоли
            //* Если бы не clear то бэкраундколор был бы только у текста и он стоял бы в позиции (10,10)

            //*+-------------------------------------------------------+
            //*|                          МАСИВЫ                       |
            //*+-------------------------------------------------------+
            //string[] array = new string[5];
            //* Следующим образом объявляем_масив_и_тип данныз даем_имя = new тип_данных[вот тут число элементов в нём] | Если надо вручную вбить то часть после = заполняем так:
            //* {вот тут нужные элементы};
            //* Читатели этих коментов не злитесь, я изучал змейку с джанго и базу немного да помню. Пишу то что может забыться xD
            //Random random = new Random();
            //int[] randomNumbersArraya = new int[10];

            //for (int i = 0; i < randomNumbersArraya.Length; i++)
            //{
            //    randomNumbersArraya[i] = random.Next(0,21);
            //    Console.WriteLine($"{i}-й индекс имеет значение = {randomNumbersArraya[i]}");
            //}

            //* В целом всё понятно. Делаем масив, через цикл вносим в него рандомные числа [0,21) и выводи значение каждого индекса масива

        }
    }
}

