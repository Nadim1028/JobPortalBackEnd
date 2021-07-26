using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalBackEnd.Model;

namespace JobPortalBackEnd.Repository
{
    public class JobSeekerAuthRepository : DatabaseRepository
    {
        
            public JobSeekerAuth Add(JobSeekerAuth jobSeekerAuth)
            {
                DatabaseContext.JobSeekerAuthTable.Add(jobSeekerAuth);
                DatabaseContext.SaveChanges();
                return jobSeekerAuth;
            }

            public List<JobSeekerAuth> GetAllJobSeekersAuth()
            {
                return DatabaseContext.JobSeekerAuthTable.ToList();
            }

            public JobSeekerAuth GetJobSeekerAuthById(int jobSeekerAuthId)
            {
                return DatabaseContext.JobSeekerAuthTable.SingleOrDefault(jobSeekerAuth => jobSeekerAuth.Id == jobSeekerAuthId);
            }

            public JobSeekerAuth GetByEmail(string email)
            {
                return DatabaseContext.JobSeekerAuthTable.SingleOrDefault(jobSeekerAuth => jobSeekerAuth.Email == email);
            }

            public JobSeekerAuth GetByUserName(string username)
            {
                return DatabaseContext.JobSeekerAuthTable.SingleOrDefault(jobSeekerAuth => jobSeekerAuth.UserName == username);
            }

        public JobSeekerAuth Update(JobSeekerAuth jobSeekerAuth)
            {
                DatabaseContext.JobSeekerAuthTable.Update(jobSeekerAuth);
                DatabaseContext.SaveChanges();
                return jobSeekerAuth;
            }

            public bool Delete(int jobSeekerAuthId)
            {
                DatabaseContext.JobSeekerAuthTable.Remove(GetJobSeekerAuthById(jobSeekerAuthId));
                DatabaseContext.SaveChanges();
                return true;
            }
    }
}
