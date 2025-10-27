using Space.Service.Autorization.Data.Repositories.Implimentations;
using Space.Service.Autorization.Models.Entity;

namespace Space.Service.Autorization.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateJwtToken(User user);
        RefreshToken GenerateRefreshToken();
        bool ValidateRefreshToken(string token);

        Guid? GetUserIdFromToken(string token);
        User? GetUserInfoFromToken(string token);
    }
}
