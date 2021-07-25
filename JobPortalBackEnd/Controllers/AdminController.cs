using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalBackEnd.Model;

namespace JobPortalBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpPost("api/admin/signIn")]
        public IActionResult AdminSignIn([FromBody] Admin adminAuth)
        {
            if (adminAuth.Username == "admin" && adminAuth.Password == "nadim123")
            {
                return Ok(true);
            }

            return Ok(false);
        }
    }
}
