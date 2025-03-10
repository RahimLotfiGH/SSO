using AUA.SSO.DomainEntities.BaseRepo;

namespace AUA.SSO.DomainEntities.Entities.Clients
{
    public class ClientPostLogoutRedirectUri : BaseEntity<int>
    {
        public string PostLogoutRedirectUri { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
    }
}
