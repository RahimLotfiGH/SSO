using AUA.SSO.DomainEntities.BaseRepo;

namespace AUA.SSO.DomainEntities.Entities.Users
{
    public class UserClaim : BaseEntity<int>
    {
        public UserClaim()
        {
        }
        public UserClaim(string claimType, string claimValue)
        {
            ClaimType = claimType;
            ClaimValue = claimValue;
        }

        public int UserId { get; set; }

        public User User { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

    }
}
