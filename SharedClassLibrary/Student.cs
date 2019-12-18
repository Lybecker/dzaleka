using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClassLibrary
{
    public class Student
    {
        public Student()
        {
            Children = new List<Child>();
        }

        public Student(string name, int age) : base()
        {
            Age = age;
            Name = name;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public List<Child> Children { get; set; }
    }

    public class Child
    {
        public string Name { get; set; }
    }
}
