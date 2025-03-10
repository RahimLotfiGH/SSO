using AUA.SSO.DomainEntities.BaseRepo;

namespace AUA.SSO.DomainEntities.Entities.Clients
{
    public class ClientGrantType : BaseEntity<int>
    {
        public string GrantType { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
    }
}
