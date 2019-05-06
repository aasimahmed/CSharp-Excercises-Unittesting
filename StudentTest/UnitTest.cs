using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q1_Exercise14;

namespace StudentTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestConstructorStudentNameOnly()
        {

            //Test access to properties
            //AAA, arrange acy assery

            Student student = new Student("Aasim", "Ahmed");


            Assert.AreEqual(student.Firstname, "Aasim");
            Assert.AreEqual(student.Lastname, "Ahmed");
            Assert.IsNull(student.Email);
            Assert.IsNull(student.Course);
        }

        [TestMethod]

        public void TestConstructorFullStudent()
        {
            Student student = new Student("Aasim", "Middle", "Ahmed" , "Computer Science", "Algorithms", "Harvard", "na@na.com", 123456789);

            Assert.AreEqual(student.TelephoneNumber, 123456789); // trailing 0 causes a problem here
            Assert.AreEqual(student.Email, "na@na.com");
            

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorFailure()
        {
            Student student = new Student();
            

            
            
        }

        [TestMethod]
        public void CreateMockStudents()
        {
            Student[] students = Student.CreateMockStudents();

            Assert.AreEqual(students[4].Firstname, "Jay");
            
            

            
        }
        [TestMethod]
        public void CheckSingletonMockStudents()
        {
            Student[] students = Student.CreateMockStudents();
            Student[] studentChecker = Student.CreateMockStudents();

            Assert.IsTrue(Object.ReferenceEquals(students, studentChecker));
            

        }

    }
}
