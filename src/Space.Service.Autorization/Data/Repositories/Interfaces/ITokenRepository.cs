using Space.Service.Autorization.Models.Entity;

namespace Space.Service.Autorization.Data.Repositories.Interfaces
{
    public interface ITokenRepository
    {
        Task<RefreshToken?> GetByTokenAsync(string token);
        Task<IEnumerable<RefreshToken>> GetByUserIdAsync(Guid userId);
        Task AddAsync(RefreshToken refreshToken);
        Task RevokeTokenAsync(string token);
        Task RevokeAllUserTokensAsync(Guid userId);
        Task<bool> IsTokenValidAsync(string token);
        Task CleanExpiredTokensAsync();
        Task SaveChangesAsync();
    }
}
