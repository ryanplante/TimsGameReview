using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    class GenreData : IGenreData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public GenreData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }
        public Task<List<GenreModel>> GetGenres()
        {
            return _dataAccess.LoadData<GenreModel, dynamic>("dbo.sp_AllGames", new { }, _connectionString.SqlConnectionName);
        }
    }
}
