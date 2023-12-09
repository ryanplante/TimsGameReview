using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IVideoGameData
    {
        public Task<List<VideoGameModel>> GetGames();

        public Task<int> DeleteGame(int gameId);

        public Task<int> AddGame(VideoGameModel model);
        public Task UpdateGame(VideoGameModel model);

        public Task<VideoGameModel> GetByID(int GameID);
    }
}