using AUA.SSO.DomainEntities.BaseRepo;

namespace AUA.SSO.DomainEntities.Entities.Clients
{
    public class ClientRedirectUri : BaseEntity<int>
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string RedirectUri { get; set; }
    }
}
