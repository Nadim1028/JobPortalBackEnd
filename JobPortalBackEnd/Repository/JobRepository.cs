using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalBackEnd.Model;

namespace JobPortalBackEnd.Repository
{
    public class JobRepository : DatabaseRepository
    {
        public Job Add(Job job)
        {
            DatabaseContext.Jobs.Add(job);
            DatabaseContext.SaveChanges();
            return job;
        }

        public Job GetById(int jobId)
        {
            /*foreach (var student in DatabaseContext.Students)
            {
                if (student.Id == studentId)
                {
                    return student;
                }
                
            }

            return null;*/

            return DatabaseContext.Jobs.SingleOrDefault(job => job.Id == jobId);
        }

        public Job GetBySearchKey(string searchKey)
        {
            /*foreach (var student in DatabaseContext.Students)
            {
                if (student.Id == studentId)
                {
                    return student;
                }
                
            }

            return null;*/

            return DatabaseContext.Jobs.SingleOrDefault(job => job.JobTitle == searchKey);
        }

        public IEnumerable<Job> GetByJobTitle(string jobTitle)
        {
            if (string.IsNullOrWhiteSpace(jobTitle))
                return GetAll();
            jobTitle = jobTitle.Trim();
            return DatabaseContext.Jobs.Where(c => c.JobTitle == jobTitle).ToList();
        }

        public List<Job> GetAll()
        {
            return DatabaseContext.Jobs.ToList();
        }

        public Job Update(Job job)
        {
            DatabaseContext.Jobs.Update(job);
            DatabaseContext.SaveChanges();
            return job;
        }

        public bool Delete(Job job)
        {
            if (job == null)
            {
                Console.WriteLine("Your job id is null");
                return true;
            }
            DatabaseContext.Jobs.Remove(job);
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}
