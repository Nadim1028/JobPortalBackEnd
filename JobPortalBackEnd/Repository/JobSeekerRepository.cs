using JobPortalBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JobPortalBackEnd.Repository
{

    
    class JobSeekerRepository : DatabaseRepository
    {
       
        public JobSeeker Add(JobSeeker jobSeeker)
        {
            DatabaseContext.JobSeekers.Add(jobSeeker);
            DatabaseContext.SaveChanges();
            return jobSeeker;
        }

        public JobSeeker GetById(int jobSeekerId)
        {
            /*foreach (var student in DatabaseContext.Students)
            {
                if (student.Id == studentId)
                {
                    return student;
                }
                
            }

            return null;*/

            return DatabaseContext.JobSeekers.SingleOrDefault(jobSeeker => jobSeeker.Id == jobSeekerId);
        }

        public List<JobSeeker> GetAll()
        {
            return DatabaseContext.JobSeekers.ToList();
        }

        public JobSeeker Update(JobSeeker jobSeeker)
        {
            DatabaseContext.JobSeekers.Update(jobSeeker);
            DatabaseContext.SaveChanges();
            return jobSeeker;
        }

        public bool Delete(JobSeeker jobSeeker)
        {
            if (jobSeeker == null)
            {
                Console.WriteLine("Your user id is null");
                return true;
            }
            DatabaseContext.JobSeekers.Remove(jobSeeker);
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}
