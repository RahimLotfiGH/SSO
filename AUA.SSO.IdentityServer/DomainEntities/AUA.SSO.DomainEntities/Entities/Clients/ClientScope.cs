using AUA.SSO.DomainEntities.BaseRepo;

namespace AUA.SSO.DomainEntities.Entities.Clients
{
    public class ClientScope : BaseEntity<int>
    {
        public string Scope { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
