using Microsoft.EntityFrameworkCore;
using JobsArgeya.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Apply> Applies { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<MailSubscribers> MailSubscribers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Primary Key identity e Seed değeri atar.
            //base.Database.ExecuteSqlCommand("DBCC CHECKIDENT('MyTable', RESEED, 1000);");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
