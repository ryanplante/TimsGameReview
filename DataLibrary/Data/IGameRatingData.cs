using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IGameRatingData
    {
        public Task<int> DeleteRating(int ratingId);
        public Task<RatingModel> GetRatingById(int ratingId);
        public Task<List<RatingModel>> GetGameRating(int gameID);
        public Task<int> RateGame(GameRatingModel gr);

    }
}