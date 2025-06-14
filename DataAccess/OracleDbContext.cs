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
            Database.Log = sql => Debug.Write(sql);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(ORACLE.OraceDefaultSchema);

            modelBuilder.Entity<Emp>();
            modelBuilder.Entity<Dept>();
            modelBuilder.Entity<Schema>();
            modelBuilder.Entity<BizModule>();
        }

        //public DbSet<Emp> Emps { get; set; }
        //public DbSet<Dept> Depts { get; set; }
        //public DbSet<Schema> Schemas { get; set; }
    }

}
