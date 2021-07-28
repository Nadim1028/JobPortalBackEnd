using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalBackEnd.Model;
using JobPortalBackEnd.Repository;

namespace JobPortalBackEnd.Controllers
{
    public class EmployerController : Controller
    {
        private readonly EmployerRepository employerRepository = new EmployerRepository();
        private readonly EmployerAuthRepository employerAuthRepository = new EmployerAuthRepository();



        [HttpPost("api/employerauth/login")]
        public IActionResult LoginEmployer([FromBody] EmployerAuth employerAuth)
        {
            var checker = employerAuthRepository.GetByUserName(employerAuth.UserName);
            if (checker != null)
            {
                if (checker.Password == employerAuth.Password)
                {
                   // var result = employerRepository.GetByUserName(employerAuth.UserName);
                    Console.WriteLine("The user password is matched.");
                    return Ok(checker);
                }

                return Ok(false);

            }
            return Ok(false);
        }


        [HttpPost("api/employerauth/add")]
        public IActionResult AddEmployerAuth([FromBody] EmployerAuth employerAuth)
        {
            var addedEmployerAuth = employerAuthRepository.Add(employerAuth);
            return Ok(true);
        }

        [HttpPost("api/employer/add")]
        public IActionResult AddEmployer([FromBody] Employer employer)
        {
            var addedEmployer = employerRepository.Add(employer);
            return Ok(true);
        }



        [HttpGet("api/employer/getById")]
        public IActionResult GetEmployerById(int employerId)
        {
            var employer = employerRepository.GetById(employerId);
            return Ok(employer);
        }


        [HttpGet("api/employer/getAll")]
        public IActionResult GetAllEmployers()
        {
            return Ok(employerRepository.GetAll());
        }

        [HttpPost("api/employer/update")]
        public IActionResult UpdateEmployer([FromBody] Employer employer)
        {
            return Ok(employerRepository.Update(employer));
        }

        [HttpDelete("api/employer/delete")]
        public IActionResult DeleteEmployer(int employerId)
        {
            var employer = employerRepository.GetById(employerId);
            employerRepository.Delete(employer);
            return Ok();
        }
    }
}
