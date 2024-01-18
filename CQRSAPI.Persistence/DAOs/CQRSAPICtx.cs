using CQRSAPI.Domain.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CQRSAPI.Persistence.DAOs
{
    public class CQRSAPICtx : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CQRSAPICtx(DbContextOptions<CQRSAPICtx> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ShowRoom3;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }
    }
}
