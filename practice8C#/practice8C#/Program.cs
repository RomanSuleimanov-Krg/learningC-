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
           Car car = new Car();
            car.Burn();
            car.Move();
            car.ShowMoveSpeed();
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

    class Car : Vehicle, IMovable, IBurnable
    {
        public void Burn()
        {
            Console.WriteLine("Горюююю");
        }

        public void Move()
        {
            Console.WriteLine("Еду");
        }

        public void ShowMoveSpeed()
        {
            Console.WriteLine("Мчим под 200");
        }
    }

    public class Vehicle 
    {
        
    }
}
