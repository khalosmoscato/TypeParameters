using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public interface ITelepathy
    {
        int PowerLevel { get; }
        void ReadMind(string alias);
    }
}
