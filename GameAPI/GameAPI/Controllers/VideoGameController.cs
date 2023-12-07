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
    public class VideoRatingController : ControllerBase
    {
        private readonly IVideoGameData _videoGameData;

        public VideoRatingController(IVideoGameData videoGameData)
        {
            _videoGameData = videoGameData;
        }

        [HttpGet("GetGames")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<VideoGameModel> result = await _videoGameData.GetGames();

                if (result != null)
                {
                    return Ok(result);
                }

                return NotFound($"No games found.");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
