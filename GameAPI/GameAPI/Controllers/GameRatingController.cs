using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameRatingController : ControllerBase
    {
        private readonly IGameRatingData _gameRatingData;

        public GameRatingController(IGameRatingData gameRatingData)
        {
            _gameRatingData = gameRatingData;
        }

        [HttpGet("GetRatingById/{ratingId}")]
        public async Task<IActionResult> Get(int ratingId)
        {
            try
            {
                var result = await _gameRatingData.GetRatingById(ratingId);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound($"Rating with ID {ratingId} not found");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpGet("GetGameRating/{gameID}")]
        public async Task<IActionResult> GetGameRating(int gameID)
        {
            try
            {
                var result = await _gameRatingData.GetGameRating(gameID);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound($"Rating with game ID {gameID} not found");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }




        [HttpDelete("DeleteRating/{ratingId}")]
        public async Task<IActionResult> Delete(int ratingId)
        {
            try
            {
                await _gameRatingData.DeleteRating(ratingId);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost("RateGame")]
        public async Task<IActionResult> RateGame([FromBody] GameRatingModel rateGameRequest)
        {
            try
            {
                var result = await _gameRatingData.RateGame(rateGameRequest);

                if (result == -1)
                {
                    // Return a conflict response if a review already exists for the customer and game.
                    return Conflict("A review already exists for this customer and game.");
                }

                // Adjust the response as needed based on the result of the RateGame operation.
                return CreatedAtAction(nameof(Get), new { ratingId = result }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
