using System;
using System.Collections.Generic;
using System.Text;

namespace SweepStakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registration;

        public Contestant(string first, string last, string email)
        {
            this.firstName = first;
            this.lastName = last;
            this.email = email;
        }

        
        public void register(int r)
        {
            //add a number in here
            registration = r;
        }
    }
}