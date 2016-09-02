using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Data.Context;
using Example.Data.Entities;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                Student student = new Student() { StudentName = "New Student" };

                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
