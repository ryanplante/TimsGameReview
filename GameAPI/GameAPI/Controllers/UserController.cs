using DataLibrary.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DataLibrary.Models; // Assuming UserModel is in the Models namespace

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserData _userData;

        public UserController(IUserData userData)
        {
            _userData = userData;
        }

        [HttpGet("VerifyPassword")]
        public async Task<IActionResult> VerifyPassword(string userName, string password)
        {
            try
            {
                var result = await _userData.VerifyPassword(userName, password);

                if (result != null)
                {
                    // Password is verified, return some success response or the user data
                    return Ok(result);
                }
                else
                {
                    // Password verification failed, return an appropriate response
                    return BadRequest("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately, log or return an error response
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}

