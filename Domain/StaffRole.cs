using System;

namespace CSharp7Demo
{
    [Flags]
    public enum StaffRole
    {
        Instructor = 0b0001,
        Researcher = 0b001,
        DepartmentChair = 0b0010,
        Cleaner = 0b0100,
        DroppingThings = 0b1000,
        Provost = 0b1000_0000_0000
    }
}
