using System;
using System.Collections.Generic;
using System.Text;

namespace SweepStakes
{
    public class SweepStakes
    {
        public string name;
        Dictionary<int, Contestant> contestants;
        List<int> registrationNumbers;
        public SweepStakes(string name)
        {
            this.name = name;
            registrationNumbers = new List<int>();
            contestants = new Dictionary<int, Contestant>();
        }

        public Contestant pickWinner()
        {
            Random rnd = new Random();
            Contestant winner = contestants[registrationNumbers[rnd.Next(0, registrationNumbers.Count-1)]];
            return winner;
        }

        public void printContestantInfo(Contestant c)
        {
            Console.WriteLine($"Name: {c.firstName} {c.lastName}\nEmail{c.email}");
        }

        public void registerContestant(Contestant c)
        {
            Random rnd = new Random();
            c.register(rnd.Next(100000, 999999));
            contestants.Add(c.registration, c);
            registrationNumbers.Add(c.registration);
           
            /*//preventing collisions of registration Num
            while (true)
            {
                try
                {
                    c.register(rnd.Next(100000, 999999));
                    contestants.Add(c.registration, c);
                    regstrationNumbers.Push(c.registration);
                    break;
                }
                catch (Exception E)
                {
                    continue;
                }
            }*/
        }

    }
}
