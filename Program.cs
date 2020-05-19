using System;
using System.Collections.Generic;

namespace First_and_reverse_team
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of lines");

            var lines = Convert.ToInt32(Console.ReadLine());

            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)

            {

                var cmdArgs = Console.ReadLine().Split();

                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));

                persons.Add(person);

            }
            
            Team team = new Team("Lexicon");

            foreach (Person p in persons)
            {
                team.AddPlayer(p);
            }

            Console.WriteLine("The size of the first team is :" + team.count);

            Console.WriteLine("The size of the reverse team is :" + team.count1);

        }
    }
}
