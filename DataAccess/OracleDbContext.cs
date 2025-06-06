using System.Data.Entity;
using System.Diagnostics;
using DataAccess.Entity;

namespace DataAccess
{

    public class OracleDbContext : DbContext
    {

        public OracleDbContext(string connectionString) : base(connectionString) 
        {
            Database.SetInitializer<OracleDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("MINAM");

            modelBuilder.Entity<Emp>();
            modelBuilder.Entity<Dept>();
            modelBuilder.Entity<Schema>();

            Database.Log = sql => Debug.Write(sql);
        }

        //public DbSet<Emp> Emps { get; set; }
        //public DbSet<Dept> Depts { get; set; }
        //public DbSet<Schema> Schemas { get; set; }

    }



}
