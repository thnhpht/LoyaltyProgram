using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Loyalty_Program.Models
{
    public class LoginModel
    {
        private LoyaltyProgramDbContext context = null;
        public LoginModel()
        {
            context = new LoyaltyProgramDbContext();
        }
        public bool Login(string email, string pass)
        {
            object[] sqlParams = 
            {
                new SqlParameter("email",email),
                new SqlParameter("pass",pass),  
            };
            var res = context.Database.SqlQuery<bool>("Login email, pass", sqlParams).SingleOrDefault();
            return res;
        }
    }
}