using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
  public class Spring2016Term
  {
    public IEnumerable<string> GetThankYouMessages(IEnumerable<Person> persons,
                                                   out int staffCount)
    {
      var messages = new List<string>();
      foreach (var person in persons)
      {
        var message = GetThankYouMessage(person);
        var staff = person as Staff;
        if (staff != null)
        { staffCount += 1; }
        messages.Add(message);
      }
      return messages;
    }

    private string GetThankYouMessage(Person person)
    {
      var student = person as Student;
      if (student != null)
      {
        if (student.GPA > 3.2m)
        { return "Thanks for being a student this term"; }
        else
        { return "Thanks for being an honor student this term"; }
      }
      var instructor = person as Instructor;
      if (instructor != null)
      { return $"Thanks for teaching {string.Join(", ", instructor.Courses)}"; }
      var staff = person as Staff;
      if (staff != null)
      { return $"Thanks for being a {staff.StaffRole.ToString()}"; }
      throw new InvalidOperationException();
    }
  }
}
