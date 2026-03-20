using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public class Mystic : Superhero, IFly, ITelepathy 
    {

        public double FlightSpeed { get; }
        public double MaxHeight { get; }

        public int PowerLevel { get; }
        public Mystic(string alias, string secreteIdentity, int age, Alignment alignment, double flightSpeed, double maxHeight, int powerLevel) : base(alias, secreteIdentity, age, alignment)
        {
            FlightSpeed = flightSpeed;
            MaxHeight = maxHeight;
            PowerLevel = powerLevel;

        }

        public Mystic(string alias, string secretIdentity, int age, Alignment alignment) : base(alias, secretIdentity, age, alignment)
        {
        }

        public void Fly(string alias)
        {
            Console.WriteLine($"{alias} swoops by look at them go!");
        }

        public void ReadMind(string alias)
        {
            Console.WriteLine($"{alias} is reading your thoughts!");
        }
    }
}
