using System;
using System.Collections.Generic;
using System.Text;

namespace SweepStakes
{
    public class UI
    {
        public Contestant getInfo()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string email = Console.ReadLine();

            return new Contestant(firstName, lastName, email);
        }

        public static int promptForOptions(string question, List<string> options)
        {
            int choice = 0;

            string s = "";

            Console.WriteLine(question);
            s = Console.ReadLine();

            Func<int> find = () =>
            {
                for (int i = 0; i < options.Count; i++)
                {
                    if (options[i].Equals(s, StringComparison.OrdinalIgnoreCase)) { return i; }
                }

                return -1;
            };

            choice = find();

            while (choice == -1)
            {
                Console.WriteLine($"I don't know what a {s} is try something else");
                Console.WriteLine(question);
                s = Console.ReadLine();
                choice = find();
            }

            return choice;
        }
    }
}
