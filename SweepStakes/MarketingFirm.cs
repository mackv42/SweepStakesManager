using System;
using System.Collections.Generic;
using System.Text;

namespace SweepStakes
{
    public class MarketingFirm
    {

        public void pickWinner(SweepStakes s)
        {

        }
        public MarketingFirm(string stackorqueue) //string here for using stack or queue
        {
            ISweepstakesManager sweepstakesManager;

            switch (stackorqueue)
            {
                case "queue":
                    sweepstakesManager = new SweepStakesQueueManager();
                    break;
                case "stack":
                    sweepstakesManager = new SweepStakesStackManager();
                    break;
                default:
                    return;
            }

            int choice = 0;
            int killSwitch = 1;

            while (choice != killSwitch)
            {
                choice = UI.promptForOptions("Would you like to Add another sweepStakes?", new List<string>(){
                    "yes", "no"
                });

                if(choice == 0)
                {
                    Console.Write("Enter the name of the SweepStakes: ");
                    string name = Console.ReadLine();
                    sweepstakesManager.SweepStakes(name);
                }
            }

            choice = 0;

            SweepStakes currentSweepStakes = sweepstakesManager.GetSweepStakes();
            while (choice != killSwitch)
            {
                Console.WriteLine($"Registering Contestants for: {currentSweepStakes.name}");
                choice = UI.promptForOptions("Enter another Contestant?", new List<string>(){
                    "yes", "no"
                });

                if(choice == 0)
                {
                    Console.Write("First Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Last Name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    currentSweepStakes.registerContestant(new Contestant(firstName, lastName, email));
                }
                if(choice == 1)
                {
                    Console.WriteLine($"Picking a winner for {currentSweepStakes.name}");
                    Contestant winner = currentSweepStakes.pickWinner();
                    Console.Write($"The winner is {winner.firstName} {winner.lastName}");
                    
                }
            }
            
        }
    }
}
