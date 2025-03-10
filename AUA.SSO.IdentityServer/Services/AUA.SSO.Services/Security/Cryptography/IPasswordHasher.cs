namespace AUA.SSO.Services.Security.Cryptography
{
    public interface IPasswordHasher
    {
        Task<string> HashAsync(string password);
        Task<bool> VerifyHashAsync(string providedPassword, string hashedPassword);
    }
}
