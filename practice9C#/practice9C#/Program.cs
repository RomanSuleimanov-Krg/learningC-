using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice9C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Weapon[] inventory = {new Gun(), new LaserGun(), new Bow()};

            foreach(var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }

            player.CheckInfo(new Box());
        }
    }

    interface IHasInfo
    {
        void ShowInfo();
    }

    interface IWeapon
    {
        int Damage { get; }
        void Fire();
    }
    
    abstract class Weapon : IHasInfo, IWeapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damge: {Damage}");
        }
    }

    class Gun : Weapon
    {
        public override int Damage { get { return 5; } }

        public override void Fire()
        {
            Console.WriteLine("Пыщ!");
        }
    }

    class LaserGun : Weapon
    {
        public override int Damage { get { return 8; } }

        public override void Fire()
        {
            Console.WriteLine("Пиу!");
        }
    }

    class Bow : Weapon
    {
        public override int Damage { get { return 2; } }

        public override void Fire()
        {
            Console.WriteLine("Пау!");
        }
    }

    class Player
    {
        
        public void CheckInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }


        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }
    }

    class Box : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("Я коробочка :)");
        }
    }
}
