using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            person.GetNameAge();

            Teacher teacher = new Teacher("Thomas", 35, "190302", "Math");
            teacher.GetNameAge();

            Student student = new Student("Sara", 19, "10506", "sara1234@gmail.ac.id");
            student.GetNameAge();

            Console.ReadKey();
            
        }
    }
}

/*          Person person = new Person();
            person.Name = "Mike";
            person.Age = 20;
            person.GetNameAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Thomas";
            teacher.Age = 35;
            teacher.TeacherId = "190302";
            teacher.Subject = "Math";
            teacher.GetNameAge();

            Student student = new Student();
            student.Name = "Sara";
            student.Age = 19;
            student.StudentId = "10506";
            student.Email = "sara1234@gmail.com";
            student.GetNameAge();

            Console.ReadKey(); */