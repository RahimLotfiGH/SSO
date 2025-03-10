
using AUA.SSO.DomainEntities.BaseRepo;

namespace AUA.SSO.DomainEntities.Entities.Clients
{
    public class Secret : BaseEntity<int>
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public DateTime? Expiration { get; set; }


    }
}
