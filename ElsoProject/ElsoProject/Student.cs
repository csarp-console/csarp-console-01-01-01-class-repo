using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoProject
{
    public class Student
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Age} éves)";
        }

        public static bool EqualTo(Student student1, Student student2)
        {
            if (student1.Name==student2.Name && student1.Age == student2.Age)
                return true ;
            else 
                return false ;
        }
    }
}
