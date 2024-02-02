using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repository.Entity;

namespace API.Context
{
    public class EFContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCore;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<UserEntity> Users { get; set; }

    }
}