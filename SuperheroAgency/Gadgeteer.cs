using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public class Gadgeteer : Superhero, ITech, IStrength
    {
        public Gadgeteer(string alias, string secreteIdentity, int age, Alignment alignment) : base(alias, secreteIdentity, age, alignment)
        {

        }

        public void Hack(string alias)
        {
            Console.WriteLine($"{alias} is hacking into the mainframe!");
        }

        public void Lift(string alias)
        {
            Console.WriteLine($"{alias} lifts with all their might!");
        }
    }
}
