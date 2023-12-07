using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreData _genreData;

        public GenreController(IGenreData genreData)
        {
            _genreData = genreData;
        }

        [HttpGet("GetGenres")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<GenreModel> result = await _genreData.GetGenres();

                if (result != null)
                {
                    return Ok(result);
                }

                return NotFound($"No genres found.");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}