using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class UsersModel
    {
        public int Id { get; set; }

        public string UName { get; set; }

        public int PermissionLevel { get; set; }

        public string Password { get; set; }
    }
}
