using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElsoProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoProject.Tests
{
    [TestClass()]
    public class StudentTestsEqualTo
    {
        [TestMethod()]
        public void EqualToTestTwoStudentEqual()
        {
            // arange
            Student student1 = new Student("Kis Adél", 17);
            Student student2 = new Student("Kis Adél", 17);

            // act
            bool actual = Student.EqualTo(student1, student2);

            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void EqualToTestTheNameIsNotEqual()
        {
            // arange
            Student student1 = new Student("Kis Adél", 17);
            Student student2 = new Student("Kis János", 17);

            // act
            bool actual = Student.EqualTo(student1, student2);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestTheAgeIsNotEqual()
        {
            // arange
            Student student1 = new Student("Kis Adél", 17);
            Student student2 = new Student("Kis Adél", 18);

            // act
            bool actual = Student.EqualTo(student1, student2);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestTheNameAndAgeNotEqual()
        {
            // arange
            Student student1 = new Student("Kis Adél", 17);
            Student student2 = new Student("Kis János", 18);

            // act
            bool actual = Student.EqualTo(student1, student2);

            // assert
            Assert.IsFalse(actual);
        }
    }
}