using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public class Mystic : Superhero, IFly, ITelepathy 
    {
        public Mytsic(string alias, string secreteIdentity, int age, Alignment alignment) : base(alias, secreteIdentity, age, alignment)
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
