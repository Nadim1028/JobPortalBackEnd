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



        [HttpPost("api/employer/login")]
        public IActionResult LoginEmployer([FromBody] Employer employer)
        {
            var checker = employerRepository.GetByUserName(employer.UserName);
            if (checker != null)
            {
                if (checker.Password == employer.Password)
                {
                    Console.WriteLine("The user password is matched.");
                    return Ok(true);
                }

                return Ok(false);

            }
            return Ok(false);
        }

        [HttpPost("api/employer/add")]
        public IActionResult AddEmployer([FromBody] Employer employer)
        {
            var addedEmployer = employerRepository.Add(employer);
            return Ok(addedEmployer);
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
