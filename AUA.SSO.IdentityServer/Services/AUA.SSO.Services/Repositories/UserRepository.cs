using AUA.SSO.DataLayer.Contexts;
using AUA.SSO.DomainEntities.Entities.Users;
using AUA.SSO.Services.Repositories;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Stores;
using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository, IUserConsentStore
{
    private readonly ApplicationDbContext _applicationDbContext;

    public UserRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public async Task RemoveUserConsentAsync(string subjectId, string clientId)
    {
        throw new NotImplementedException();
    }

    public async Task StoreUserConsentAsync(Consent consent)
    {
        throw new NotImplementedException();
    }


    public async Task<Consent?> GetUserConsentAsync(string subjectId, string clientId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> IsUserActiveAsync(int userId)
    {
        return await _applicationDbContext.Set<User>().AnyAsync(x => x.Id == userId && x.IsActive);
    }

    public Task<User> FindUserByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public async Task<User?> FindUserByUserNameAsync(string username)
    {
        return await _applicationDbContext.Set<User>().FirstOrDefaultAsync(x => x.Username == username);
    }

    public Task<IEnumerable<UserClaim>> FindUserClaimsByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserLogin>> FindUserLoginsByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<User> FindUserByLoginProviderAsync(string loginProvider, string providerKey)
    {
        throw new NotImplementedException();
    }
}


