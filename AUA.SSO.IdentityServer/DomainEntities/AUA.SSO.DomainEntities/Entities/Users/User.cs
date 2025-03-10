using AUA.SSO.DomainEntities.BaseRepo;

namespace AUA.SSO.DomainEntities.Entities.Users
{
    public class User : BaseEntity<int>
    {
        public bool Deleted { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTime? LastLoginDateUtc { get; set; }
        public DateTime? CannotLoginUntilDateUtc { get; set; }
        public HashSet<UserClaim> UserClaims { get; set; }
        public HashSet<UserLogin> UserLogins { get; set; }
       // public HashSet<Role> Roles { get; set; } = new();
      //  public HashSet<PersistedGrant> PersistedGrants { get; set; } = new();
    }
}