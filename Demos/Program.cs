using Demos.Collection;
using System;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            students[0] = new Student() { Id = 1, FirstName = "a", LastName = "aa" };
            students[1] = new Student() { Id = 2, FirstName = "b", LastName = "bb" };
            students[2] = new Student() { Id = 2, FirstName = "c", LastName = "cc" };
            var enumerator = new Course(students);
            foreach (Student student in enumerator)
            {
                Console.WriteLine($"Id:{student.Id}");
                Console.WriteLine($"First Name:{student.FirstName}");
                Console.WriteLine($"Last Name:{student.LastName}");
                Console.WriteLine("................");
            }
        }
    }
}
