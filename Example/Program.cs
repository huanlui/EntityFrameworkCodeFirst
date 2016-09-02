using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Data;
using Example.Data.Entities;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                Student added = new Student() { StudentName = "New Student" };

                context.Students.Add(added);
                context.SaveChanges();

                foreach (var student in context.Students)
                {
                    Console.WriteLine("{0} {1}", student.StudentID, student.StudentName);
                }
            }
        }
    }
}
