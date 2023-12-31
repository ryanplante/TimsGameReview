﻿using DataLibrary.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

// Assuming UserModel is in the Models namespace

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

        [HttpPost("VerifyPassword")]
        public async Task<IActionResult> VerifyPassword([FromBody] Models.LoginModel loginModel)
        {
            try
            {
                var result = await _userData.VerifyPassword(loginModel.Username, loginModel.Password);

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