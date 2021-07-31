using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalBackEnd.Model;

namespace JobPortalBackEnd.Controllers
{
    public class AdminController : ControllerBase
    {
        [HttpPost("api/admin/login")]
        public IActionResult AdminSignIn([FromBody] Admin adminAuth)
        {
            if (adminAuth.UserName == "admin" && adminAuth.Password == "nadim123")
            {
                return Ok(true);
            }

            return Ok(false);
        }
    }
}
//C:\Users\bsse1\source\repos\JobPortalBackEnd\JobPortalBackEnd\Controllers\AdminController.cs