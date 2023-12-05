using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IUserData
    {
        public Task<UsersModel> VerifyPassword(string userName, string password);
    }
}
