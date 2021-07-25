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
        


        [HttpPost("api/jobseeker/add")]
        public IActionResult AddJobSeeker([FromBody] JobSeeker jobSeeker)
        {
            var addedJobSeeker = jobSeekerRepository.Add(jobSeeker);
            return Ok(addedJobSeeker);
        }

        [HttpGet("api/jobseeker/getById")]
        public IActionResult GetJobSeekerById(int jobSeekerId)
        {
            var student = jobSeekerRepository.GetById(jobSeekerId);
            return Ok(student);
        }


        [HttpGet("api/jobseeker/getAll")]
        public IActionResult GetAllJobSeekers()
        {
            return Ok(jobSeekerRepository.GetAll());
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
