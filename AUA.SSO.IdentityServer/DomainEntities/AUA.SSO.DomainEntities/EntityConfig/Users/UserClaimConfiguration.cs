using AUA.SSO.DomainEntities.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.SSO.DomainEntities.EntityConfig.Users
{
    internal class UserClaimConfiguration : IEntityTypeConfiguration<UserClaim>
    {
        public void Configure(EntityTypeBuilder<UserClaim> builder)
        {
           // builder.ToTable("UserClaims");
            builder.HasKey(x => x.Id);
           // builder.Ignore(x => x.EntityState);

            builder.Property(x => x.UserId).IsRequired();
            //builder.Property(x => x.Id).HasColumnType("int").UseIdentityColumn();
            builder.Property(x => x.ClaimType).IsRequired().HasMaxLength(100);
            builder.Property(x => x.ClaimValue).IsRequired().HasMaxLength(200);
            builder.HasIndex(x => new { x.UserId, x.ClaimType });
        }
    }
}