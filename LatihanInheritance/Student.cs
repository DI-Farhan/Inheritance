using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Email { get; set; }

        public Student (string name, int age, string id, string subject) : base(name, age)
        {
            Name = name;
            Age = age;
        }
    }
}
