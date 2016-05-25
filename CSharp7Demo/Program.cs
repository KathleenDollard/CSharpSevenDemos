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
      IEnumerable<string> thankYouMessages = term.GetThankYouMessages(persons.Values);
      Console.Write(string.Join("\n", thankYouMessages));
      Console.Read();
    }
  }
}
