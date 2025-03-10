using AUA.SSO.DomainEntities.BaseRepo;
using Microsoft.EntityFrameworkCore;

namespace AUA.SSO.DataLayer.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
        : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BaseEntity<>).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
