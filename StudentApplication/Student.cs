using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{
    public class Student:AddData
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Level { get; set; }
        public string Course { get; set; }

        public Student(string fname, string sname, string email, string phone, string adrs1, string adrs2, string city, string county, string level, string course)
        {
            FirstName = fname;
            Surname = sname;
            Email = email;
            Phone = phone;
            AddressLine1 = adrs1;
            AddressLine2 = adrs2;
            City = city;
            County = county;
            Level = level;
            Course = course;

        }

        public void AddStudentToDB()
        {
            AddNewStudent(FirstName, Surname, Email, Phone, AddressLine1, AddressLine2, City, County, Level, Course);

        }
    }
}
