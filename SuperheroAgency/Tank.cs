using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public class Tank : Superhero, IFly, IStrength
    {
        public double FlightSpeed { get;  }
        public double MaxHeight { get;  }
        public int StrengthLevel { get; }
        public Tank(string alias, string secreteIdentity, int age, Alignment alignment, double flightSpeed, double maxHeight, int strengthlevel) : base(alias, secreteIdentity, age, alignment)
        {
            FlightSpeed = flightSpeed;
            MaxHeight = maxHeight;
            StrengthLevel = strengthlevel;


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
