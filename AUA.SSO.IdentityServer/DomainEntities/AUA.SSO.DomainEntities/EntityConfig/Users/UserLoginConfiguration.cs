using AUA.SSO.DomainEntities.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.SSO.DomainEntities.EntityConfig.Users
{
    internal class UserLoginConfiguration : IEntityTypeConfiguration<UserLogin>
    {
        public void Configure(EntityTypeBuilder<UserLogin> builder)
        {
           // builder.ToTable("UserLogins");
            builder.HasKey(x => x.Id);
            //builder.Ignore(x => x.EntityState);
           // builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ProviderKey).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LoginProvider).IsRequired().HasMaxLength(100);
            builder.HasIndex(userLogin => new { userLogin.UserId, userLogin.LoginProvider }).IsUnique();
        }
    }
}