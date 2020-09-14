using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Exchange_rate.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Rate> Rates { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        // устанавливаем подключение к базе данных
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=my_db;Username=my_user;Password=my_pw");
        }
    }
}
