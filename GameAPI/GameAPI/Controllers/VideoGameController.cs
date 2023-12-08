using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpGet("GetGame/{gameId}")]
        public async Task<IActionResult> GetGame(int GameID)
        {
            try
            {
                var result = await _videoGameData.GetByID(GameID);

                if (result != null && result.Any())
                {
                    return Ok(result.FirstOrDefault());
                }

                return NotFound($"Game with ID {GameID} not found.");
            }
            catch (Exception ex)
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

        [HttpPut("UpdateGame/{id}")]
        public async Task<IActionResult> UpdateGame(int id, [FromBody] VideoGameModel updateGameRequest)
        {
            try
            {
                // Ensure the ID in the URL and the model are the same
                if (id != updateGameRequest.Id)
                {
                    return BadRequest("ID mismatch");
                }

                await _videoGameData.UpdateGame(updateGameRequest);

                // Return NoContent as the standard response for a successful PUT request
                return NoContent();
            }
            catch (Exception ex)
            {
                // Log the exception, if logging is set up
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

    }
}
