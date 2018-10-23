using System;
using System.Collections.Generic;
using System.Linq;
using Fall2018Term;

namespace CSharp7Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, IEndOfTermMessageInfo> persons =
                    GetData()
                        .ToDictionary(
                              x => x.Key,
                              x => (IEndOfTermMessageInfo)(PersonMessageRole)x.Value);
            IEnumerable<string> thankYouMessages = persons.Select(x => x.Value.ThankYouMessage);
        }

        private static IDictionary<Int32, Person> GetData()
        {
            ISeedData<Person> seedData = new SeedDataForPerson();
            return seedData.GetData();
        }
    }
}
