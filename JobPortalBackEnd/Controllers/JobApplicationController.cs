using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalBackEnd.Model;
using JobPortalBackEnd.Repository;
namespace JobPortalBackEnd.Controllers
{
    public class JobApplicationController : Controller
    {
        private readonly JobApplicationRepository jobApplicationRepository = new JobApplicationRepository();



        [HttpPost("api/jobApplication/add")]
        public IActionResult AddJobApplication([FromBody] JobApplication jobApplication)
        {
            if (jobApplication != null)
            {
                var addedJobApplication = jobApplicationRepository.Add(jobApplication);
                return Ok(true);
            }

            else
            {
                return Ok(false);
            }
            
        }

        [HttpGet("api/jobApplication/getById")]
        public IActionResult GetJobApplicationById(int jobApplicationId)
        {
            var jobApplication = jobApplicationRepository.GetById(jobApplicationId);
            return Ok(jobApplication);
        }


        /* [HttpGet("api/job/getAll")]
                public IActionResult GetAllJobs()
                {
                    IEnumerable<Job> jobs = jobRepository.GetAll();
                    return Ok(jobs);//IEnumerable<Jobpost> jobs = _dataRepository.GetAll()

                }*/

        [HttpGet("api/jobApplication/getAll")]
        public IActionResult GetAllJobApplications()
        {
            IEnumerable<JobApplication> jobApplications= jobApplicationRepository.GetAll();
            return Ok(jobApplications);
        }

        [HttpPost("api/jobApplication/update")]
        public IActionResult UpdaterJobApplication([FromBody] JobApplication jobApplication)
        {
            return Ok(jobApplicationRepository.Update(jobApplication));
        }

        [HttpDelete("api/jobApplication/delete")]
        public IActionResult DeleteJobApplication(int jobApplicationId)
        {
            var jobApplication = jobApplicationRepository.GetById(jobApplicationId);
            jobApplicationRepository.Delete(jobApplication);
            return Ok();
        }


        [HttpGet("api/jobApplication/getApplicationsByEmployerId")]
        public IActionResult GetAllJobsByEmployerId(int employerId)
        {
            IEnumerable<JobApplication> jobApplications = jobApplicationRepository.GetAllByEmployerId(employerId);
            return Ok(jobApplications);

        }
    }
}
