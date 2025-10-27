using Space.Service.Autorization.Models.Entity;
using Space.Service.Autorization.Services.Interfaces;

namespace Space.Service.Autorization.Services.Implementations
{
    public class TokenService : ITokenService
    {
        public string GenerateJwtToken(User user)
        {
            throw new NotImplementedException();
        }

        public RefreshToken GenerateRefreshToken()
        {
            throw new NotImplementedException();
        }

        public Guid? GetUserIdFromToken(string token)
        {
            throw new NotImplementedException();
        }

        public User? GetUserInfoFromToken(string token)
        {
            throw new NotImplementedException();
        }

        public bool ValidateRefreshToken(string token)
        {
            throw new NotImplementedException();
        }
    }
}
