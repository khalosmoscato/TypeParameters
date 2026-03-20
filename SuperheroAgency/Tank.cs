using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public class Tank : Superhero, IFly, IStrength
    {
        public Tank(string alias, string secreteIdentity, int age, Alignment alignment) : base(alias, secreteIdentity, age, alignment)
        {

        }

        public void Fly(string alias)
        {
            Console.WriteLine($"{alias} swoops by look at them go!");
        }

        public void Lift(string alias)
        {
            Console.WriteLine($"{alias} lifts with all their might!");
        }
    }
}
