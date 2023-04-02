using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private EshopContext context = null;
        public AccountModel()
        {
            context = new EshopContext();
        }
        public bool Login(string username, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            var res = context.Database.SqlQueryRaw<bool>("AccountLogin @username, @password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
