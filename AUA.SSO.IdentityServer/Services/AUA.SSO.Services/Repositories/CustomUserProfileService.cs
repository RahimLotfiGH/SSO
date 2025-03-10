using System.Security.Claims;
using Duende.IdentityServer.Extensions;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Services;

namespace AUA.SSO.Services.Repositories
{
    public class CustomUserProfileService : IProfileService
    {
        private readonly IUserRepository _userRepository;

        public CustomUserProfileService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var subjectId = int.Parse(context.Subject.GetSubjectId());

            var claims = new List<Claim>(context.Subject.Claims);
            claims.Add(new Claim("N_Code", "407355100"));
            context.IssuedClaims = claims;
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var subjectId = int.Parse(context.Subject.GetSubjectId());
            context.IsActive = await _userRepository.IsUserActiveAsync(subjectId);
        }
    }
}
