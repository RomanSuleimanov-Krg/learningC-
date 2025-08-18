using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice8C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            IMovable human = new Human();
        }
    }

    interface IMovable
    {
        void Move();
        void ShowMoveSpeed();
    }

    interface IBurnable
    {
        void Burn();
    }
    
    class Vehicle
    {

    }

    class Car : Vehicle, IMovable , IBurnable
    {
        public void Move()
        {

        }

        public void Burn()
        {

        }

        public void ShowMoveSpeed()
        {

        }
    }

    class Human : IMovable
    {
        public void Move()
        {

        }

        public void ShowMoveSpeed()
        {

        }
    }
    //Интерфейсы в C#
}
