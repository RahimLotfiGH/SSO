using AUA.SSO.DomainEntities.BaseRepo;

namespace AUA.SSO.DomainEntities.Entities.Users
{
    public class UserLogin : BaseEntity<int>
    {
        public int UserId { get; set; }
        public string ProviderKey { get; set; }
        public string LoginProvider { get; set; }
        public User User { get; set; }
    }
}
