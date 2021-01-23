using System;

namespace _07_ListBox
{
    class Student: IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int CompareTo(Student other)
        {
            return this.Surname.CompareTo(other.Surname);
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
