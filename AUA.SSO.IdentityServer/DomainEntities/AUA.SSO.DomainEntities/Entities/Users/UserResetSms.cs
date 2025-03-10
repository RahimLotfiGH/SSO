using AUA.SSO.DomainEntities.BaseRepo;

namespace AUA.SSO.DomainEntities.Entities.Users
{
    public class UserResetSms : BaseEntity<int>
    {
        public int UserId { get; set; }
        public string Message { get; set; }
        public string SecurityCode { get; set; }
        public DateTime CreatedDate { get; set; }

        public User User { get; set; }
    }
}
