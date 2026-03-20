using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public class Gadgeteer : Superhero, ITech, IStrength
    {

        public string Gadget { get; }
        public int StrengthLevel { get; }
        public Gadgeteer(string alias, string secreteIdentity, int age, Alignment alignment, string gadget, int strengthLevel) : base(alias, secreteIdentity, age, alignment)
        {
            Gadget = gadget;
            StrengthLevel = strengthLevel;

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
