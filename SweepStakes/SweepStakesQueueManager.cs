using System;
using System.Collections.Generic;
using System.Text;

namespace SweepStakes
{
    public class SweepStakesQueueManager : ISweepstakesManager
    {
        Queue<SweepStakes> sweepstakes;

        public SweepStakesQueueManager()
        {
            sweepstakes = new Queue<SweepStakes>();
        }

        public void SweepStakes( string Name )
        {
            sweepstakes.Enqueue(new SweepStakes(Name));
        }

        public SweepStakes GetSweepStakes()
        {
            return sweepstakes.Dequeue();
        }
    }
}
