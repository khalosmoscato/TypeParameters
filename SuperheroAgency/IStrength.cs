using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public interface IStrength
    {
        int StrengthLevel { get; }
        void Lift(string alias);
    }
}
