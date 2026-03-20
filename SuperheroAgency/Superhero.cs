using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public abstract class Superhero
    {
        public string Alias { get; }
        public string SecretIdentity { get; }
        public int Age { get; }
        public Alignment Alignment { get; }

        public Superhero(string alias, string secretIdentity, int age, Alignment alignment)
        {
            Alias = alias; 
            SecretIdentity = secretIdentity;
            Age = age;
            Alignment = alignment;
        }

    }
}
