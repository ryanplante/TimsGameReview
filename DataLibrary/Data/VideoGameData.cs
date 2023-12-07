using DataLibrary.Db;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataLibrary.Models;

namespace DataLibrary.Data
{
    public class VideoGameData : IVideoGameData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public VideoGameData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<List<VideoGameModel>> GetGames()
        {
            return await _dataAccess.LoadData<VideoGameModel, dynamic>("dbo.sp_AllGames", new { }, _connectionString.SqlConnectionName);
        }

        public Task<int> DeleteGame(int gameId)
        {
            return _dataAccess.SaveData("spGame_Delete", new { Id = gameId }, _connectionString.SqlConnectionName);
        }
    }
}
