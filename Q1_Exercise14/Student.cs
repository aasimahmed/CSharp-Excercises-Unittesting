using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Exercise14
{
    public class Student
    {
        private string _firstname;
        private string _middlename;
        private string _lastname;
        private string _course;
        private string _subject;
        private string _university;
        private string _email;
        private int _telephonenumber;
        private static int _studentcount;
        private int _studentid;
        private static Student[] _mockstudents;

        public static Student[] CreateMockStudents()
        {
            //Normally I would here, randomly generate using some kind of generator values for each field.
            // For simplicity lets just 
            if (Student._mockstudents is null)
            {
                return Student._mockstudents;
            }

            Student._mockstudents = new Student[5];

            _mockstudents[0] = new Student("James", "Harrsion");
            _mockstudents[1] = new Student("Cookie", "Cutter");
            _mockstudents[2] = new Student("Dale", "Chuck-E-Cheese-Chance");
            _mockstudents[3] = new Student("Big-Lenny", "Persin");
            _mockstudents[4] = new Student("Jay", "Masters");

            return Student._mockstudents;

        }
        public Student() 
        {
            throw new ArgumentNullException("No values passed in for Student name");
        }

        public Student(string firstName, string lastName)
        {
            this._firstname = firstName;
            this._lastname = lastName;
            this._studentid = _studentcount;
            _studentcount++;
        }

        public Student(string firstName, string middleName, string lastName, string course, string subject, string university, string email, int telephoneNumber)
        {
            this._firstname = firstName;
            this._middlename = middleName;
            this._middlename = lastName;
            this._course = course;
            this._subject = subject;
            this._university = university;
            this._email = email;
            this._telephonenumber = telephoneNumber;
            this._studentid = _studentcount;

            _studentcount++;

        }

        public string Firstname // declaring as a property not a method
        {
            get
            {
                return this._firstname;
            }


        }


        
        public string Middlename
        {
            get { return this._middlename; }
        }

        public string Lastname
        {
            get { return this._lastname; }
        }

        public string Course
        {
            get { return this._course; }
        }
        
        public string University
        {
            get { return this._university; }
        }

        public string Subject
        {
            get { return this._subject; }
        }
        public int TelephoneNumber
        {
            get { return this._telephonenumber; }
            set { this._telephonenumber = value; }
        }

        
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }


        }

        public static Object GetMockStudents()
        {
            return Student._mockstudents;
        }

        public string GetStudentFullName()
        {
            return String.Format("{0}{1} {2}", this._firstname, String.IsNullOrEmpty(this._middlename) ? "" : " " + this._middlename, this._lastname);

        }
        public void StudentPersonalInformation()
        {
            Console.WriteLine("First Name: {0}", this._firstname);
            if (!String.IsNullOrEmpty(this._middlename))
            {
                Console.WriteLine("Middle Name(s): {0}", this._middlename);
            }
            Console.WriteLine("Last Name: {0}", this._lastname);

            Console.WriteLine("Email: {0}", this._email);

            Console.WriteLine("Telephone Number: {0}", this._telephonenumber);
        }

    }
}
