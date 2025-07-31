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


            for (int i = 0;  i < 10; i++)
            {
                Console.WriteLine($"{i}");
            }

            
        }
     }
}

