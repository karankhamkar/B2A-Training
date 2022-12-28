using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }

    }
}
