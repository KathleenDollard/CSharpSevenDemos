




using System.Collections.Generic;

namespace CSharp7Demo
{
  public class SeedData
  {
    public static IDictionary<int, Person> GetPersons()
    {
      var dictionary = new Dictionary<int, Person>()
      {
        [1] = new Instructor("Albert Einstein", 100000, new string[] { "Physics", "Relativity" }),
        [2] = new Instructor("Anders Jonas Ångström", 10000, new string[] { "Chemistry" }),
        [3] = new Staff("Donald Trump", StaffRole.Cleaner, 10_000_000),
        [4] = new Student("Benson Joeris", 4.0m),
        [5] = new Student("Kathleen Dollard", 3.1m)
      };
      return dictionary;
    }
  }
}
