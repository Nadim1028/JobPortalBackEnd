using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalBackEnd.Model;

namespace JobPortalBackEnd.Repository
{
    public class EmployerRepository : DatabaseRepository
    {
        public Employer Add(Employer employer)
        {
            DatabaseContext.Employers.Add(employer);
            DatabaseContext.SaveChanges();
            return employer;
        }

        public Employer GetById(int employerId)
        {
            /*foreach (var student in DatabaseContext.Students)
            {
                if (student.Id == studentId)
                {
                    return student;
                }
                
            }

            return null;*/

            return DatabaseContext.Employers.SingleOrDefault(employer => employer.Id == employerId);
        }

        public Employer GetByUserName(string username)
        {
            
            return DatabaseContext.Employers.SingleOrDefault(employer => employer.UserName == username);
        }

        public List<Employer> GetAll()
        {
            return DatabaseContext.Employers.ToList();
        }

        public Employer Update(Employer employer)
        {
            DatabaseContext.Employers.Update(employer);
            DatabaseContext.SaveChanges();
            return employer;
        }

        public bool Delete(Employer employer)
        {
            if (employer == null)
            {
                Console.WriteLine("Your employer id is null");
                return true;
            }
            DatabaseContext.Employers.Remove(employer);
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}

