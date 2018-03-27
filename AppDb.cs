using System;
using Microsoft.EntityFrameworkCore;

namespace Mvc
{
    public class AppDb : DbContext
    {
        public AppDb()
        {
            var connectionString = Configuration["ConnectionStrings:MySqlConnection"];
        }
    }
}