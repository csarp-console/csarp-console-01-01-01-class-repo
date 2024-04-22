using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasodikProjeckt
{
    public class Teacher
    {
        public string Name;
        public DateTime DateOfBirth;

        public Teacher(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"{Name} ({DateOfBirth.ToString("yyyy.dd.MM")})";
        }
    }
}
