using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalBackEnd.Model;
using JobPortalBackEnd.Repository;

namespace JobPortalBackEnd.Controllers
{
    public class JobController : Controller
    {
        private readonly JobRepository jobRepository = new JobRepository();



        [HttpPost("api/job/add")]
        public IActionResult AddJob([FromBody] Job job)
        {
            var addedJob = jobRepository.Add(job);
            return Ok(true);
        }

        [HttpGet("api/job/getById")]
        public IActionResult GetJobById(int jobId)
        {
            var job = jobRepository.GetById(jobId);
            return Ok(job);
        }


        [HttpGet("api/job/getByJobTitle")]
        public IActionResult GetJobFilterByJobTitle([FromQuery]string jobTitle)
        {
            IEnumerable<Job> jobs = jobRepository.GetByJobTitle(jobTitle);

            return Ok(jobs);
        }


        [HttpGet("api/job/getAll")]
        public IActionResult GetAllJobs()
        {
            return Ok(jobRepository.GetAll());
        }

        [HttpPost("api/job/update")]
        public IActionResult UpdaterJob([FromBody] Job job)
        {
            var updatedJob = jobRepository.Update(job);
            return Ok(true);
        }

        [HttpDelete("api/job/delete")]
        public IActionResult DeleteJob(int jobId)
        {
            var job = jobRepository.GetById(jobId);
            jobRepository.Delete(job);
            return Ok(true);
        }
    }
}
