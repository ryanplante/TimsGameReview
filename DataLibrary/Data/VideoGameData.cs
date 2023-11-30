using DataLibrary.Db;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataLibrary.Models;

namespace DataLibrary.Data
{
    public class VideoGameData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public VideoGameData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public Task<List<VideoGameModel>> GetGame()
        {
            return _dataAccess.LoadData<VideoGameModel, dynamic>("dbo.sp_AllGames", new { }, _connectionString.SqlConnectionName);
        }
    }
}
