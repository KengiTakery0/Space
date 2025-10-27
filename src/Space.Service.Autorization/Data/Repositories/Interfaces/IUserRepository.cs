using Space.Service.Autorization.Models.Entity;

namespace Space.Service.Autorization.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByEmailAsync(string email);
        Task<User?> GetByPhoneAsync(string phone);

        Task<User?> GetUserByRefreshTokenAsync(string refreshToken);
        Task<User?> GetUserByAccessTokenAsync(string accessToken);

        Task<bool> ExistsByEmailAsync(string email);
        Task<bool> ExistsByPhoneAsync(string phone);

     

    }
}
