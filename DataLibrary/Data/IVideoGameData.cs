using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IVideoGameData
    {
        public Task<List<VideoGameModel>> GetGames();

        public Task<int> DeleteGame(int gameId);
    }
}