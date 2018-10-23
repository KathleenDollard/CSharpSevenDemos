using System;
using CSharp7Demo;

namespace Fall2018Term
{
    public class PersonMessageRole : Role<Person>, ISalutation, IEndOfTermMessageInfo
    {
        private PersonMessageRole(Person value) : base(value) { }

        public string Opening
            => Underlying.Name;
        public string ThankYouMessage
        {
            get
            {
                switch (Underlying)
                {
                    case Student student when (student.GPA > 3.2m):
                        return $"Thanks {student.Name} for being  an honor student this term, sorry about the flood";
                    case Student student2:
                        return "Thanks for being a student this term";
                    case Instructor instructor:
                        return $"Thanks for teaching {string.Join(", ", instructor.Courses)}";
                    case Staff staff:
                        return $"Thanks for being a {staff.StaffRole.ToString()}";
                    default:
                        throw new InvalidOperationException("Do what!");
                }

            }
        }
        public string Closing { get; }

        public static implicit operator PersonMessageRole(Person value)
            => new PersonMessageRole(value);
    }
}
