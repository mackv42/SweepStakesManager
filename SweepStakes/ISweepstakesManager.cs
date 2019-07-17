using System;
using System.Collections.Generic;
using System.Text;

namespace SweepStakes
{
    public interface ISweepstakesManager
    {
        void SweepStakes(string Name);
        SweepStakes GetSweepStakes();
    }
}
