using AUA.SSO.DomainEntities.Entities.Users;

namespace AUA.SSO.Services.Repositories
{
    public interface IUserRepository
    {
        Task<bool> IsUserActiveAsync(int userId);
        Task<User> FindUserByEmailAsync(string email);
        Task<User> FindUserByUserNameAsync(string username);
        Task<IEnumerable<UserClaim>> FindUserClaimsByUserIdAsync(int userId);
        Task<IEnumerable<UserLogin>> FindUserLoginsByUserIdAsync(int userId);
        Task<User> FindUserByLoginProviderAsync(string loginProvider, string providerKey);
    }
}
