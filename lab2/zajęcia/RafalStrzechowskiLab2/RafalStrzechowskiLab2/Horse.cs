using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafalStrzechowskiLab2
{
    public class Horse : Creature
    {
        static readonly int horseMaxSpeed = 42;//static readonly lub const

        public Horse()
        {
            MaxSpeed = horseMaxSpeed;
        }

        public Horse(string horseName, int numberOfLegs)
        {
            Name = horseName;
            NumberOfLegs = numberOfLegs;
            MaxSpeed = horseMaxSpeed;
        }

        public void Move()
        {
            Console.WriteLine("i'm gracefully running!");
        }

        public override void DoSomething()
        {
            Console.WriteLine("I'm a horse and I am doing something.");
        }
    }
}
