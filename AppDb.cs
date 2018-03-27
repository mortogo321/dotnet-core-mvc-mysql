using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Mvc.Models;

namespace Mvc
{
    public class AppDb : DbContext
    {
        private IConfiguration Config;

        public AppDb(IConfiguration config)
        {
            Config = config;
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql(@"server=" + Config["Mysql:host"] +
                ";database=" + Config["Mysql:database"] +
                ";uid=" + Config["Mysql:user"] +
                ";password=" + Config["Mysql:password"] + ";");
    }
}