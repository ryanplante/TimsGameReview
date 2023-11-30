using DataLibrary.Models;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IGameRatingData
    {
        Task<int> DeleteRating(int ratingId);
        Task<RatingModel> GetRatingById(int ratingId);
        Task<int> RateGame(VideoGameModel game, RatingModel rate);
    }
}