using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_TH03
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student() { }
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;

        }
        // ghi đè
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}
