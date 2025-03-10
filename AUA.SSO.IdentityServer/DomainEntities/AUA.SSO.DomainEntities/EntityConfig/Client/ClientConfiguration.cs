using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.SSO.DomainEntities.EntityConfig.Client
{
    internal class ClientConfiguration : IEntityTypeConfiguration<Entities.Clients.Client>
    {
        public void Configure(EntityTypeBuilder<Entities.Clients.Client> builder)
        {
            //builder.ToTable("Clients");
           
            builder.HasKey(x => x.Id);
                 

            builder.HasIndex(x => x.ClientId).IsUnique();
            builder.HasMany(x => x.RedirectUris).WithOne(x => x.Client).HasForeignKey(x => x.ClientId).IsRequired();
            builder.HasMany(x => x.AllowedScopes).WithOne(x => x.Client).HasForeignKey(x => x.ClientId).IsRequired();
            builder.HasMany(x => x.ClientSecrets).WithOne(x => x.Client).HasForeignKey(x => x.ClientId).IsRequired();
            builder.HasMany(x => x.AllowedGrantTypes).WithOne(x => x.Client).HasForeignKey(x => x.ClientId).IsRequired();           
            builder.HasMany(x => x.PostLogoutRedirectUris).WithOne(x => x.Client).HasForeignKey(x => x.ClientId).IsRequired();
           
        }
    }
}