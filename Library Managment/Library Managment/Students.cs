using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment
{
    class Students
    {
        private static int studentID;
        private static string stuName;
        private static string regNo;
        private static string semester;
        private static string department;
        private static string section;
        private static string gender;
        private static string contact;
        private static string mail;
        private static string cnic;
        private static string fatherName;

        public static void setStudentData(string studentID, string stuName, string fatherName, string cnic, string gender, string contact, string mail, string regNo, string section, string semester, string department)
        {
            Students.studentID = Convert.ToInt32(studentID);
            Students.stuName = stuName;
            Students.fatherName = fatherName;
            Students.cnic = cnic;
            Students.gender = gender;
            Students.contact = contact;
            Students.mail = mail;
            Students.regNo = regNo;
            Students.section = section;
            Students.semester = semester;
            Students.department = department;
        }

        public static int passStudentID()
        {
            return Students.studentID;
        }
    }
}