namespace AUA.SSO.Services.Security.Cryptography
{
    public class BcryptPasswordHasher: IPasswordHasher
    {
        public async Task<string> HashAsync(string password)
        {
            return await Task.FromResult(BCrypt.Net.BCrypt.HashPassword(password));
        }

        public async Task<bool> VerifyHashAsync(string providedPassword, string hashedPassword)
        {
            return await Task.FromResult(BCrypt.Net.BCrypt.Verify(providedPassword, hashedPassword));
        }
    }
}
