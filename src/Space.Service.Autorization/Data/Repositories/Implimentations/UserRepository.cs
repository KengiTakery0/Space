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
        public async Task<User?> GetByIdAsync(Guid id)
        {
            //return await _context.Users
            //    .Include(u => u.Settings)
            //    .FirstOrDefaultAsync(x => x.Id == id);
            throw new NotImplementedException();
        }

        public async Task CreateAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Remove(user);
                await _context.SaveChangesAsync();
            }
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

        public async Task UpdateAsync(User user)
        {
            user.Updated_At = DateTime.UtcNow;
            _context.Update(user);
            await _context.SaveChangesAsync();
            await Task.CompletedTask;

        }
    }
}
