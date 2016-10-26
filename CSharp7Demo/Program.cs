using System;
using System.Collections.Generic;

namespace CSharp7Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, Person> persons = GetData();
            var term = new Spring2016TermMessaging();
            var staffCount = 0;
            IEnumerable<string> thankYouMessages = term.GetThankYouMessages(
                    persons.Values, out staffCount);

            void WriteResults()
            {
                Console.WriteLine($"Staff count: {staffCount}");
                Console.Write(string.Join("\n", thankYouMessages));
                Console.Read();
            }

            WriteResults();
        }

        private static IDictionary<Int32, Person> GetData()
        {
            ISeedData<Person> seedData = new SeedDataForPerson();
            return seedData.GetData();
        }
    }
}
