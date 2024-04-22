using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasodikProjeckt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasodikProjeckt.Tests
{
    [TestClass()]
    public class TeacherRepoTests
    {
        [TestMethod()]
        public void OldestTestEmptyList()
        {
            // arrange
            TeacherRepo  teacherRepo= new TeacherRepo(new List<Teacher>());
            // act
            string actualTeacherName = teacherRepo.Oldest();
            string expectedTeachName = string.Empty;
            // assert
            Assert.AreEqual(actualTeacherName, expectedTeachName);
        }

        [TestMethod()]
        public void OldestTestFirstTeachIsOldest()
        {
            // arrange
            TeacherRepo teacherRepo = new TeacherRepo(
                new List<Teacher>
                {
                    new Teacher("Matek Marcel", new DateTime(1981,10,25)),
                    new Teacher("Magyar Melinda", new DateTime(1981,11,25)),
                    new Teacher("Zene Zorán", new DateTime(1981,11,24)),
                }
            );
            // act
            string actualTeacherName = teacherRepo.Oldest();
            string expectedTeachName = "Matek Marcel";
            // assert
            Assert.AreEqual(actualTeacherName, expectedTeachName);
        }

        [TestMethod()]
        public void OldestTestLastTeachIsOldest()
        {
            // arrange
            TeacherRepo teacherRepo = new TeacherRepo(
                new List<Teacher>
                {
                    new Teacher("Matek Marcel", new DateTime(1981,10,25)),
                    new Teacher("Magyar Melinda", new DateTime(1981,11,25)),
                    new Teacher("Zene Zorán", new DateTime(1980,11,24)),
                }
            );
            // act
            string actualTeacherName = teacherRepo.Oldest();
            string expectedTeachName = "Zene Zorán";
            // assert
            Assert.AreEqual(actualTeacherName, expectedTeachName);
        }

        [TestMethod()]
        public void OldestTestOldestInTheMiddle()
        {
            // arrange
            TeacherRepo teacherRepo = new TeacherRepo(
                new List<Teacher>
                {
                    new Teacher("Matek Marcel", new DateTime(1981,11,25)),
                    new Teacher("Magyar Melinda", new DateTime(1981,10,25)),
                    new Teacher("Zene Zorán", new DateTime(1981,12,24)),
                }
            );
            // act
            string actualTeacherName = teacherRepo.Oldest();
            string expectedTeachName = "Magyar Melinda";
            // assert
            Assert.AreEqual(actualTeacherName, expectedTeachName);
        }


    }
}