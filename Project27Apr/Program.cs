using System;

namespace Project27Apr
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherStudentInfo tsi1 = new TeacherStudentInfo("Doe", "John", "Finance");
            TeacherStudentInfo tsi2 = new TeacherStudentInfo("Dany", "Joe", "Admin");
            TeacherStudentInfo tsi3 = new TeacherStudentInfo("Lynn", "Rose", "CS");
            TeacherStudentInfo tsi4 = new TeacherStudentInfo("Jang", "Lee", "Music");
            Console.WriteLine("StudentName StudentTeacher StudentSubject");
            tsi1.GetStudentDetails();
            tsi2.GetStudentDetails();
            tsi3.GetStudentDetails();
            tsi4.GetStudentDetails();
            //Console.WriteLine("Hello World!");
        }
    }
}
