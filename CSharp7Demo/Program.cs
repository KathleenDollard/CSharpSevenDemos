using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            IDictionary<int, Person> persons = SeedData.GetPersons();
            var term = new Spring2016Term();
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
    }
}
