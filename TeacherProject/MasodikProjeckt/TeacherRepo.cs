using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasodikProjeckt
{
    public class TeacherRepo
    {
        private List<Teacher> _teachers=new List<Teacher>();

        public TeacherRepo(List<Teacher> teachers)
        {
            _teachers = teachers;
        }

        public List<Teacher> FindAll() => _teachers;

        public string Oldest()
        {
            if (!FindAll().Any())
            {
                return string.Empty;
            }
            else
            {
                DateTime minDate = FindAll().Select(teacher => teacher.DateOfBirth).Min();
                Teacher? teacher = FindAll().Where(teacher => teacher.DateOfBirth == minDate).FirstOrDefault();
                return teacher is null ? string.Empty : teacher.Name;
            }
        }
    }
}
