using Microsoft.EntityFrameworkCore;
using Space.Service.Autorization.Data.Repositories.Interfaces;
using Space.Service.Autorization.Models.Entity;

namespace Space.Service.Autorization.Data.Repositories.Implimentations
{
    public class UserRepository : IUserRepository
    {
        private AppDbContext _context;
        private TokenRepository _tokenRepository;
        public UserRepository(AppDbContext context)
        {
            this._context = context;
            this._tokenRepository = new TokenRepository();
        }

        public async Task<bool> ExistsByEmailAsync(string email)
        {
          return await _context.Users.AnyAsync(x => x.Email == email);
        }

        public async Task<bool> ExistsByPhoneAsync(string phone)
        {
            return await _context.Users.AnyAsync(x => x.PhoneNumber == phone);
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

       
        public async Task<User?> GetByPhoneAsync(string phone)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.PhoneNumber == phone);
        }

        public Task<User?> GetUserByAccessTokenAsync(string accessToken)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetUserByRefreshTokenAsync(string refreshToken)
        {
            throw new NotImplementedException();
        }
    }
}
