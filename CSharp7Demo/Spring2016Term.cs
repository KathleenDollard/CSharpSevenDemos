//using System;
//using System.Collections.Generic;

//namespace CSharp7Demo
//{
//    public class Spring2016TermMessaging
//    {
//        public IEnumerable<string> GetThankYouMessages(IEnumerable<Person> persons,
//                                                       out int staffCount)
//        {
//            var messages = new List<string>();
//            staffCount = 0;
//            foreach (var person in persons)
//            {
//                var message = GetThankYouMessage(person);

//                var staff = person as Staff;
//                if (staff != null)
//                { staffCount += 1; }

//                if (person is Staff staff1)
//                { staffCount += 1; }

//                messages.Add(message);
//            }
//            return messages;
//        }

//        private string GetThankYouMessage(Person person)
//        {
//            //var x = GetThankYouMessageUpdateWithSwitch(person);
//            //var y = GetThankYouMessageUpdateWithIfPatterns(person);
//            var student = person as Student;
//            if (student != null)
//            {
//                if (student.GPA > 3.2m)
//                {
//                    return String.Format(
//                        "Thanks {0} for being  an honor student this term, sorry about the flood",
//                        student.Name);
//                }
//                else
//                { return "Thanks for being a student this term, sorry about the flood"; }
//            }
//            var instructor = person as Instructor;
//            if (instructor != null)
//            { return $"Thanks for teaching {string.Join(", ", instructor.Courses)}"; }
//            var staff = person as Staff;
//            if (staff != null)
//            { return $"Thanks for being a {staff.StaffRole.ToString()}"; }
//            throw new InvalidOperationException();
//        }

//        private String GetThankYouMessageUpdateWithIfPatterns(Person person)
//        {
//            if (person is Student student && student.GPA > 3.2m)
//            {
//                return $"Thanks {student.Name} for being  an honor student this term, sorry about the flood";
//            }
//            if (person is Student student2)
//            { return "Thanks for being an honor student this term, sorry about the flood"; }
//            if (person is Instructor instructor)
//            { return $"Thanks for teaching {string.Join(", ", instructor.Courses)}"; }
//            if (person is Staff staff)
//            { return $"Thanks for being a {staff.StaffRole.ToString()}"; }
//            throw new InvalidOperationException();
//        }

//        private String GetThankYouMessageUpdateWithSwitch(Person person)
//        {
//            switch (person)
//            {
//                case Student student when (student.GPA > 3.2m):
//                    return $"Thanks {student.Name} for being  an honor student this term, sorry about the flood";
//                case Student student2:
//                    return "Thanks for being a student this term";
//                case Instructor instructor:
//                    return $"Thanks for teaching {string.Join(", ", instructor.Courses)}";
//                case Staff staff:
//                    return $"Thanks for being a {staff.StaffRole.ToString()}";
//                default:
//                    throw new InvalidOperationException("Do what!");
//            }
//        }   

//    }
//}
