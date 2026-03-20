using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public interface ITech
    {
        string Gadget { get; }
        void Hack(string alias);
    }
}
