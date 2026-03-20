using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public interface IFly
    {
        double FlightSpeed { get; }
        double MaxHeight { get;  }
        void Fly(string alias);

    }
}
