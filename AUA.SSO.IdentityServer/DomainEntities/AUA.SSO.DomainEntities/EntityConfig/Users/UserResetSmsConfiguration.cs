using AUA.SSO.DomainEntities.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.SSO.DomainEntities.EntityConfig.Users
{
    public sealed class UserResetSmsConfiguration : IEntityTypeConfiguration<UserResetSms>
    {
        public void Configure(EntityTypeBuilder<UserResetSms> builder)
        {
            //builder.ToTable("UserResetMessages");

            builder.HasKey(x => x.Id);
            //builder.Ignore(x => x.EntityState);
            builder.Property(x => x.UserId).IsRequired();
            //builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.Message).HasMaxLength(250).IsRequired();
            builder.Property(x => x.SecurityCode).HasMaxLength(5).IsRequired();

            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
