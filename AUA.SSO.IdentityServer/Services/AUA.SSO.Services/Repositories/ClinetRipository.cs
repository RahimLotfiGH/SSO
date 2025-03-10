using AUA.SSO.DataLayer.Contexts;
using AUA.SSO.DomainEntities.Entities.Clients;
using Duende.IdentityServer.Stores;
using Microsoft.EntityFrameworkCore;

namespace AUA.SSO.Services.Repositories
{
    public class ClinetRipository : IClientStore
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ClinetRipository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Duende.IdentityServer.Models.Client?> FindClientByIdAsync(string clientId)
        {
            var client = await _applicationDbContext.Set<Client>()
                    .Where(x => x.ClientId.Equals(clientId)).Include(x => x.RedirectUris)
                    .Include(x => x.ClientSecrets)
                    .Include(x => x.PostLogoutRedirectUris)
                    .Include(x => x.AllowedGrantTypes)
                    .Include(x => x.AllowedScopes)
                    .SingleOrDefaultAsync();

            if (client == null)
                throw new ArgumentNullException(nameof(client), "clinet not find");


            return new Duende.IdentityServer.Models.Client
            {
                ClientId = clientId,
                RequireClientSecret = false,
                //  IdentityTokenLifetime = 1000 ,//defaults to 300 seconds / 5 minutes,
                ClientSecrets = client.ClientSecrets.Select(p => new Duende.IdentityServer.Models.Secret
                {
                    Description = p.Description,
                    Type = p.Type,
                    //Expiration = p.Expiration,
                    Value = p.Value,

                }).ToList(),

                AllowedGrantTypes = client.AllowedGrantTypes.Select(p => p.GrantType).ToList(),
                RedirectUris = client.RedirectUris.Select(p => p.RedirectUri).ToList(),
                PostLogoutRedirectUris = client.PostLogoutRedirectUris.Select(p => p.PostLogoutRedirectUri).ToList(),
                AllowedScopes = client.AllowedScopes.Select(p => p.Scope).ToList(),
                //RequireClientSecret= client.RequireClientSecret,
                RequirePkce = false,

            };

        }
    }
}
