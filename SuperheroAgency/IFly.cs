using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public interface IFly
    {
        double FlightSpeed { get; }
        double Max111height { get;  }
        void Fly(string alias);

    }
}
