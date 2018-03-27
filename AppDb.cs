using Microsoft.EntityFrameworkCore;

namespace Mvc
{
    public class AppDb : DbContext
    {
        var connectionString = Configuration["ConnectionStrings:MySqlConnection"];
    }
}