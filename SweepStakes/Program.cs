using System;
using System.Collections.Generic;
namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = UI.promptForOptions("Would you like the sweepstakes to be a stack or a queue", new List<string>()
            {
                "stack", "queue"
            });

            new MarketingFirm((option == 0) ? "stack" : "queue");
        }
    }
}
