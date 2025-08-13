using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice4C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Render render = new Render();
            Player player = new Player(55,10);

            //player.X = -1000;
            //player.Y = -500;

            //Таким образом за две строки ломается программа
            //Если это раскоментить то это переопределение не сработает

            render.Draw(player.X,player.Y);
        }
    }

    
    class Render
    {
        public void Draw(int x, int y, char character = '@')
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(character);
            Console.ReadKey(true);
        }
    }
    
    class Player
    {
        //Хорошая практика я так думаю:
        //private int _x;
        //private int _y;
        
        //Тоже хорошая практика:
        public int X { get;private set; }
        public int Y { get;private set; }

        //Так низя я так думаю:
        //private int X;
        //private int Y;

        //Было вот так

        //Вот это для первого случая который закоменчен:
        //public int X
        //{
        //    get 
        //    {
        //        return _x;
        //    }
        //    private set
        //    {
        //        _x = value;
        //    }
        //}

        //Вообще в этих гет и сет можно добавить условия для более валидной программы, однако это всё уже игра с мелочами, основа в любом случае положена

        //Это тоже для первого случая который закоменчен:
        //public int Y
        //{
        //    get
        //    {
        //        return _y;
        //    }

        //    private set
        //    {
        //        _y = value;
        //    }
        //}

        public Player(int x, int y)
        {
            //_x = x;
            //_y = y;

            X = x;
            Y = y;
        }

        //public Player(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //}
        //И было вот так
    }

    //Это пример не правильной инкапсуляции т.к. можно вручную поменять координаты и всё сломается.
    //По итогу думаю понятно обозначил коментами что плохая практика, а что можно использовать
}
