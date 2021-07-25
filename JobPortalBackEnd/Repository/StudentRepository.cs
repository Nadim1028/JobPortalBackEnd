using JobPortalBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JobPortalBackEnd.Repository
{
    public class StudentRepository : DatabaseRepository
    {
        public Student Add(Student student)
        {
            DatabaseContext.Students.Add(student);
            DatabaseContext.SaveChanges();
            return student;
        }

        public List<Student> GetAll()
        {
            return DatabaseContext.Students.ToList();
        }

        public Student GetById(int studentId)
        {
            /*foreach (var student in DatabaseContext.Students)
            {
                if (student.Id == studentId)
                {
                    return student;
                }
                
            }

            return null;*/

            return DatabaseContext.Students.SingleOrDefault(student => student.Id == studentId);
        }

        public Student Update(Student student)
        {
            DatabaseContext.Students.Update(student);
            DatabaseContext.SaveChanges();
            return student;
        }

        public bool Delete(Student student)
        {
            if (student == null)
            {
                Console.WriteLine("Your user id is null");
                return true;
            }
            DatabaseContext.Students.Remove(student);
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}
