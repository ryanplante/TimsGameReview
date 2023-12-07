using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorReview.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UName { get; set; }
        public int PermissionLevel { get; set; }
        public string Password { get; set; }
    }

}
