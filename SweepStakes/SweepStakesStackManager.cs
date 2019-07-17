using System;
using System.Collections.Generic;
using System.Text;

namespace SweepStakes
{
    class SweepStakesStackManager : ISweepstakesManager
    {
        Stack<SweepStakes> sweepstakes;

        public SweepStakesStackManager()
        {
            sweepstakes = new Stack<SweepStakes>();
        }

        public void SweepStakes(string name)
        {
            sweepstakes.Push(new SweepStakes(name));
        }

        public SweepStakes GetSweepStakes()
        {
            return sweepstakes.Pop();
        }
    }
}
