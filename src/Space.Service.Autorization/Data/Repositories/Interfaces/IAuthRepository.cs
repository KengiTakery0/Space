using Space.Service.Autorization.Data.Repositories.Implimentations;
using Space.Service.Autorization.Models.Entity;

namespace Space.Service.Autorization.Data.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        Task<User?> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);

        Task<RefreshToken?> GetRefreshTokenAsync(string token);
        Task AddRefreshTokenAsync(RefreshToken token);

        Task<bool> ValidatePasswordAsync(string email, string password);
    }
}
