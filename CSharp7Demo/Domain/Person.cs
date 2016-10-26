using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
    public class Person
    {
        public Person(string name)
        { Name = name; }
        public string Name { get; }
    }
    public class Student : Person
    {
        public Student(string name, decimal gpa) : base(name)
        {
            GPA = gpa;
            Name = name;
        }
        public decimal GPA { get; }
        public new string Name { get; }
    }
    public class Staff : Person
    {
        public Staff(string name, StaffRole staffRole, decimal salary) : base(name)
        { StaffRole = staffRole; }
        public StaffRole StaffRole { get; }
        public decimal Salary { get; }
        public new string Name { get; }
    }
    public class Instructor : Staff
    {
        public Instructor(string name, decimal salary, IEnumerable<string> courses)
            : base(name, StaffRole.Instructor, salary)
        {
            Courses = courses;
        }
        public IEnumerable<string> Courses { get; private set; }
        public new decimal Salary { get; }
        public new string Name { get; }
    }
    [Flags]
    public enum StaffRole
    {
        Instructor = 1,
        Researcher = 2,
        DepartmentChair = 4,
        Cleaner = 8,
        Provost = 4096
    }
}
