using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalBackEnd.Model;

namespace JobPortalBackEnd.Repository
{
    public class JobApplicationRepository : DatabaseRepository
    {
        public JobApplication Add(JobApplication jobApplication)
        {
            DatabaseContext.JobApplications.Add(jobApplication);
            DatabaseContext.SaveChanges();
            return jobApplication;
        }

        public JobApplication GetById(int jobApplicationId)
        {
            /*foreach (var student in DatabaseContext.Students)
            {
                if (student.Id == studentId)
                {
                    return student;
                }
                
            }

            return null;*/

            return DatabaseContext.JobApplications.SingleOrDefault(jobApplication => jobApplication.Id == jobApplicationId);
        }

        public List<JobApplication> GetAll()
        {
            return DatabaseContext.JobApplications.ToList();
        }


        public List<JobApplication> GetAllByEmployerId(int employerId)
        {
            return DatabaseContext.JobApplications.Where(x => x.EmployerId == employerId).ToList();
        }

        public JobApplication Update(JobApplication jobApplication)
        {
            DatabaseContext.JobApplications.Update(jobApplication);
            DatabaseContext.SaveChanges();
            return jobApplication;
        }

        public bool Delete(JobApplication jobApplication)
        {
            if (jobApplication == null)
            {
                Console.WriteLine("Your job application id is null");
                return true;
            }
            DatabaseContext.JobApplications.Remove(jobApplication);
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}
