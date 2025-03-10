using AUA.SSO.DomainEntities.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.SSO.DomainEntities.EntityConfig.Users
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //builder.ToTable("Users");

            builder.HasKey(x => x.Id);
          //  builder.Property(x => x.Id).IsRequired().UseIdentityColumn();

            //builder.Ignore(x => x.EntityState);
            builder.Property(x => x.UpdatedDate);
            builder.Property(x => x.LastLoginDateUtc);
            builder.Property(x => x.Deleted).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.CannotLoginUntilDateUtc);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.AccessFailedCount).IsRequired();
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(80);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(200).IsRequired(false);
            //builder.Property(x => x.Password).HasColumnType("varchar").IsRequired().HasMaxLength(100);
            //builder.Property(x => x.Username).IsRequired().HasColumnType("varchar").HasMaxLength(100);
           // builder.Property(x => x.PhoneNumber).IsRequired().HasColumnType("varchar").HasMaxLength(11);
           // builder.Property(x => x.NationalCode).IsRequired().HasColumnType("varchar").HasMaxLength(11);

            builder.HasIndex(x => x.Username, "IX_USERS_USERNAME").IsUnique();

            builder.HasMany(x => x.UserClaims).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.UserLogins).WithOne(x => x.User).HasForeignKey(x => x.UserId);

            //builder
            //   // .HasMany(x => x.Roles)
            //    .WithMany(x => x.Users)
            //    .UsingEntity(config =>
            //    {
            //        config.ToTable("UserRoles");
            //        config.Property<int>("RoleId");
            //        config.Property<int>("UserId");

            //        config.HasKey("UserId", "RoleId");
            //    });
        }
    }
}