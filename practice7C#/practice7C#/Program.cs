using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice7C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Beehaviour
    {
        public virtual void Update()
        {

        }
    }

    class Walker : Beehaviour
    {
        public override void Update()
        {
            Console.WriteLine("Иду");
        }
    }

    class Jumper : Walker
    {
        public override void Update()
        {
            Console.WriteLine("Прыгаю");
        }
    }
}
