using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    class UserData : IUserData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public UserData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<UsersModel> VerifyPassword(string userName, string password)
        {
            var parameters = new
            {
                UName = userName,
                Password = password
            };

            var recs = await _dataAccess.LoadData<UsersModel, dynamic>("dbo.sp_VerifyPassword", parameters, _connectionString.SqlConnectionName);

            return recs.FirstOrDefault();

        }
    }
}
