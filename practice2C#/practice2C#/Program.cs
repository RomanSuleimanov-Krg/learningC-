using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Performer worker1 = new Performer("Вова");
            Performer worker2 = new Performer("Роман");

            Task[] tasks = { new Task(worker1, "Сделать уборку дома"), new Task(worker2, "Построить дом") };

            Board scedule = new Board(tasks);

            scedule.ShowAllTasks();
        }
    }

    class Performer
    {
        public string Name;

        public Performer(string name)
        {
            Name = name;
        }
    }
    
    // Класс исполнителя задачи который имеет одно публичное поле: "имя" и конструктор

    class Board
    {
        public Task[] Tasks;

        public Board(Task[] tasks)
        {
            Tasks = tasks;
        }

        public void ShowAllTasks()
        {
            for (int i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }
    }

    // Класс доски который имеет публичное поле - список: "задачи", конструктор, и метод который показывает все задачи, который через цикл показывает
        //что он содержит

    class Task
    {
        public Performer Worker;
        public string Description;

        public Task(Performer worker, string description)
        {
            Worker = worker;
            Description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Ответственный: {Worker.Name}\nОписание задачи: {Description}.\n");
        }
    }

    // Вот это уже более вложенная ситуация. Имеется класс: "задания" который в себе содержит два поля: другой объект работника "Worker" и публичную 
        //строку "описание" которое включает в себя описание задания. Методы: конструктор и показывание информации о задании.

    // В итоге мы имеем такую ситуацию, что один объект может включать в себя другой. Ну это я так понял
}
