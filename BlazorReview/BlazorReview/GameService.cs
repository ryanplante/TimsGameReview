using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;
using BlazorReview.Models;

namespace BlazorReview
{
    public class GameService
    {
        private readonly HttpClient _httpClient;

        public GameService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<GameModel>> GetGamesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<GameModel>>("/api/VideoRating/GetGames");
        }

        public async Task<List<RatingModel>> GetGameRatingsAsync(int gameId)
        {
            return await _httpClient.GetFromJsonAsync<List<RatingModel>>($"/api/GameRating/GetGameRating/{gameId}");
        }
    }
}
