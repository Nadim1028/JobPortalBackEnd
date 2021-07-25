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
            var addedJobApplication = jobApplicationRepository.Add(jobApplication);
            return Ok(addedJobApplication);
        }

        [HttpGet("api/jobApplication/getById")]
        public IActionResult GetJobApplicationById(int jobApplicationId)
        {
            var jobApplication = jobApplicationRepository.GetById(jobApplicationId);
            return Ok(jobApplication);
        }


        [HttpGet("api/jobApplication/getAll")]
        public IActionResult GetAllJobApplications()
        {
            return Ok(jobApplicationRepository.GetAll());
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
    }
}
