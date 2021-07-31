using Microsoft.AspNetCore.Mvc;
using JobPortalBackEnd.Model;
using JobPortalBackEnd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalBackEnd.Controllers
{
    public class JobSeekerController : Controller
    {
        private readonly JobSeekerRepository jobSeekerRepository = new JobSeekerRepository();
        private readonly JobSeekerAuthRepository jobSeekerAuthRepository = new JobSeekerAuthRepository();



        [HttpPost("api/jobseekerauth/login")]
        public IActionResult LoginJobSeeker([FromBody] JobSeekerAuth jobSeekerAuth1)
        {
            var jobSeekerAuth = jobSeekerAuthRepository.GetByUserName(jobSeekerAuth1.UserName);
            if (jobSeekerAuth != null)
            {
                if (jobSeekerAuth.Password == jobSeekerAuth1.Password)
                {
                    Console.WriteLine("The user password is matched.");
                    return Ok(jobSeekerAuth);
                }

                return Ok(false);

            }
            return Ok(false);
        }

        [HttpPost("api/jobseeker/add")]
        public IActionResult AddJobSeeker([FromBody] JobSeeker jobSeeker)
        {
            var addedJobSeeker = jobSeekerRepository.Add(jobSeeker);
            return Ok(true);
        }


        [HttpPost("api/jobseekerauth/add")]
        public IActionResult AddJobSeekerAuth([FromBody] JobSeekerAuth jobSeekerAuth)
        {
            var addedJobSeekerAuth = jobSeekerAuthRepository.Add(jobSeekerAuth);
            return Ok(true);
        }

        [HttpGet("api/jobseeker/getById")]
        public IActionResult GetJobSeekerById(int jobSeekerId)
        {
            var student = jobSeekerRepository.GetById(jobSeekerId);
            return Ok(student);
        }


        [HttpGet("api/jobseekerAuth/getAll")]
        public IActionResult GetAllJobSeekers()
        {
            IEnumerable<JobSeekerAuth> jobSeekerAuths = jobSeekerAuthRepository.GetAll();
            return Ok(jobSeekerAuths);

            
        }

        [HttpPost("api/jobseekerauth/update")]
        public IActionResult UpdateJobSeekerAuth([FromBody] JobSeekerAuth jobSeekerAuth)
        {
            return Ok(jobSeekerAuthRepository.Update(jobSeekerAuth));
        }

        [HttpPost("api/jobseeker/update")]
        public IActionResult UpdateJobSeeker([FromBody] JobSeeker jobSeeker)
        {
            return Ok(jobSeekerRepository.Update(jobSeeker));
        }

        [HttpDelete("api/jobseeker/delete")]
        public IActionResult DeleteJobSeeker(int jobSeekerId)
        {
            var jobSeeker = jobSeekerRepository.GetById(jobSeekerId);
            jobSeekerRepository.Delete(jobSeeker);
            return Ok();
        }


        [HttpDelete("api/jobseekerAuth/delete")]
        public IActionResult DeleteEmployerAuth(int jobseekerAuthId)
        {
            var jobseekerAuth = jobSeekerAuthRepository.GetById(jobseekerAuthId);
            jobSeekerAuthRepository.Delete(jobseekerAuth);
            return Ok(true);
        }
    }
}


/*try
            {
                JobSeeker j  = new JobSeeker();
                j = jobSeekerRepository.GetById(jobSeeker.Id);
                if (j != null)
                {
                    objEmp.EmpName = employee.EmpName;
                    objEmp.Address = employee.Address;
                    objEmp.EmailId = employee.EmailId;
                    objEmp.DateOfBirth = employee.DateOfBirth;
                    objEmp.Gender = employee.Gender;
                    objEmp.PinCode = employee.PinCode;

                }
                int i = this.objEntity.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
            */
