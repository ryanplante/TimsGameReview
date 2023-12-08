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

        [HttpPost("AddGame")]
        public async Task<IActionResult> AddGame([FromBody] VideoGameModel addGameRequest)
        {
            try
            {
                int result = await _videoGameData.AddGame(addGameRequest);

                // Adjust the response as needed based on the result of the RateGame operation.
                return CreatedAtAction(nameof(Get), new { Id = result }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpDelete("DeleteGame/{gameId}")]
        public async Task<IActionResult> Delete(int gameId)
        {
            try
            {
                await _videoGameData.DeleteGame(gameId);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
