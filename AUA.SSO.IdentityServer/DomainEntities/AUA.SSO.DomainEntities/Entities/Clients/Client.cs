
using AUA.SSO.DomainEntities.BaseRepo;

namespace AUA.SSO.DomainEntities.Entities.Clients
{
    public class Client : BaseEntity<int>
    {
        public string ClientId { get; set; }
        //public string InvokerKey { get; set; }
        public bool RequireClientSecret { get; set; } = true;
        public List<ClientGrantType> AllowedGrantTypes { get; set; }
        public List<ClientScope> AllowedScopes { get; set; }
        public List<ClientSecret> ClientSecrets { get; set; }
        public List<ClientRedirectUri> RedirectUris { get; set; }
        public HashSet<ClientPostLogoutRedirectUri> PostLogoutRedirectUris { get; set; }
    }
}
