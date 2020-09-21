
using AS.Models;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace AS.Context
{
    class CPContext : DbContext
    {
        public DbSet<Nomenclatura> Nomenclaturas { get; set; }
        public CPContext() : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var sqliteInitializer = new SqliteCreateDatabaseIfNotExists<CPContext>(modelBuilder);
            Database.SetInitializer(sqliteInitializer);
        }
    }
    }
