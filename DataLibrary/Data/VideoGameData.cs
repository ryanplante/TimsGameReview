using DataLibrary.Db;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataLibrary.Models;
using Dapper;
using System.Data;

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

        public async Task<int> DeleteGame(int gameId)
        {
            return await _dataAccess.SaveData("spGame_Delete", new { Id = gameId }, _connectionString.SqlConnectionName);
        }

        public async Task<int> AddGame(VideoGameModel model)
        {
            DynamicParameters p = new DynamicParameters();

            p.Add("Title", model.Title);
            p.Add("Description", model.Description);
            p.Add("Price", model.Price);
            p.Add("Genre", model.Genre);

            p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);

            await _dataAccess.SaveData("sp_AddGame", p, _connectionString.SqlConnectionName);

            return p.Get<int>("Id");
        }

        public async Task UpdateGame(VideoGameModel model)
        {
            DynamicParameters p = new DynamicParameters();

            p.Add("Id", model.Id);
            p.Add("Title", model.Title);
            p.Add("Description", model.Description);
            p.Add("Price", model.Price);
            p.Add("Genre", model.Genre);

            await _dataAccess.SaveData("sp_UpdateGame", p, _connectionString.SqlConnectionName);
        }

        public async Task<List<VideoGameModel>> GetByID(int GameID)
        {
            return await _dataAccess.LoadData<VideoGameModel, dynamic>("dbo.sp_GameByID", new {GameID = GameID }, _connectionString.SqlConnectionName);
        }

    }
}
