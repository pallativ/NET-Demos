using System.Collections;

namespace Demos.Collection
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Course : IEnumerable
    {
        private Student[] students;
        public Course(Student[] students)
        {
            this.students = students;
        }
        public IEnumerator GetEnumerator()
        {
            return new CourseEnumerator(this.students);
        }
    }
    public class CourseEnumerator : IEnumerator
    {
        private readonly Student[] students;
        private int position = -1;

        public CourseEnumerator(Student[] students)
        {
            this.students = students;
        }
        public object Current => this.students[position];

        public bool MoveNext()
        {
            if (position < this.students.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
