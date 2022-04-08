using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class ObjectOrientedProgrammingCourse
        {
            public List<ObjectOrientedProgrammingCourse> Students = new List<ObjectOrientedProgrammingCourse>();
            public string studentName { get; set; }
            public string studentId { get; set; }
            public string identificationCard { get; set; }
            public decimal mark { get; set; }

            public void SetStudentDetail(string StudentName, string StudentID, string IdentificationCard, decimal Mark)
            {
                ObjectOrientedProgrammingCourse student1 = new ObjectOrientedProgrammingCourse()
                {
                    studentName = StudentName,
                    studentId = StudentID,
                    identificationCard = IdentificationCard,
                    mark = Mark
                };

                Students.Add(student1);
            }
        }
        public class Student : ObjectOrientedProgrammingCourse
        {
            public void DisplayAllStudentDetail()
            {
                var newList = Students.OrderBy(n => n.studentName);
                var i = 1;
                foreach (var anothernewlist in newList)
                {
                    Console.WriteLine(i + ")" + " " + anothernewlist.studentName + " " + anothernewlist.studentId + " " + anothernewlist.identificationCard + " " + anothernewlist.mark);
                    i++;
                }
            }
            public void DisplayAllStudentRanking()
            {
                var newList = Students.OrderByDescending(n => n.mark);
                var i = 1;
                foreach (var anothernewlist in newList)
                {
                    Console.WriteLine(i + ")" + " " + anothernewlist.studentName + " " + anothernewlist.studentId + " " + anothernewlist.identificationCard + " " + anothernewlist.mark);
                    i++;
                }
            }

        }
        static void Main(string[] args)
        {
            Student astudent = new Student();
            astudent.SetStudentDetail("Ali", "0001", "A001", 80);
            astudent.SetStudentDetail("Ah Kao", "0002", "A002", 79);
            astudent.SetStudentDetail("Muthu", "0004", "A004", 60);
            astudent.SetStudentDetail("Qing Qing", "0003", "A003", 90);
            astudent.SetStudentDetail("Hua Hua", "0005", "A005", 40);
            Console.WriteLine("Sort by Name (Name, StudentId, IdentificationId, Mark):");
            astudent.DisplayAllStudentDetail();
            Console.WriteLine("\nSort by Mark (Name, StudentId, IdentificationId, Mark):");
            astudent.DisplayAllStudentRanking();
        }
    }
}