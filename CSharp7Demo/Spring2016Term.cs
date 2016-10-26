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
            var x = 0b01;
            var z = 10_000_000_000;

            var y = from person in persons
                    let message = person match
                            (
                        case Student st when (st.GPA > 3.2m) :
                            "Thanks for being a student this term"
                        case Student st :
                            "Thanks for being a student this term"
                        case Instructor(string name, decimal salary, IEnumerable<string> courses) :
                            $"Thanks for teaching {string.Join(", ", courses)}"
                        case Staff staff1 :
                            $"Thanks for being a {staff1.StaffRole.ToString()}"
                        case * :
                            throw new InvalidOperationException("Do what!")
                        )
                    select new { person.Name, message };
            var messages = new List<string>();
            staffCount = 0;
            foreach (var person in persons)
            {
                var message = GetThankYouMessage(person);

                var staff = person as Staff;
                if (staff != null)
                { staffCount += 1; }

                if (person is Staff staff1)
                { staffCount += 1; }

                messages.Add(message);
            }
            return messages;
        }

        private string GetThankYouMessage(Person person)
        {
            #region 1
            var x = person match
                (
                case Student st when (st.GPA > 3.2m) :
                     "Thanks for being a student this term"
                case Student st :
                     "Thanks for being a student this term"
                case Instructor(string name, decimal salary, IEnumerable<string> courses) :
                    $"Thanks for teaching {string.Join(", ", courses)}"
                case Staff staff1 :
                     $"Thanks for being a {staff1.StaffRole.ToString()}"
                case * :
                    throw new InvalidOperationException("Do what!")
            );
            #endregion

            #region 2
            switch (person)
            {
                case Student st when (st.GPA > 3.2m):
                    return $"Thanks {st.Name}for being a student this term";
                case Student st:
                    return "Thanks for being a student this term";
                case Instructor(string name, decimal salary, IEnumerable<string> courses):
                    return $"Thanks for teaching {string.Join(", ", courses)}";
                case Staff staff1:
                    return $"Thanks for being a {staff1.StaffRole.ToString()}";
                default:
                    throw new InvalidOperationException("Do what!");
            }
            #endregion

            if (person is Student student)
            {
                if (student.GPA > 3.2m)
                { return "Thanks for being a student this term"; }
                else
                { return "Thanks for being an honor student this term"; }
            }
            var instructor = person as Instructor;
            if (instructor != null)
            {
                return $"Thanks for teaching {string.Join(", ", instructor.Courses)}";
            }
            var staff = person as Staff;
            if (staff != null)
            {
                return $"Thanks for being a {staff.StaffRole.ToString()}";
            }
            throw new InvalidOperationException();
        }
    }
}
