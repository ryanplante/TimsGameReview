using DataLibrary.Models;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IGameRatingData
    {
        public Task<int> DeleteRating(int ratingId);
        public Task<RatingModel> GetRatingById(int ratingId);
        public Task<int> RateGame(VideoGameModel game, RatingModel rate);
    }
}