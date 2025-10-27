using Microsoft.AspNetCore.Identity.Data;
using Space.Backend.Models.Enteties;
using Space.Backend.Proto;

namespace Space.Backend.Services.AutorizationService
{
    public interface IAutorizationService
    {
        Task<User> RegisterAsync(RegistrRequest request)
        {
            var user = new User
            {
                Id = request.Id,
                Name = request.Username,
                Email = request.Email,
            };
            return Task.FromResult(user);
        }
        //Task<User> LoginAsync(LoginRequest request);
        Task<bool> UserExistsAsync(string username, string email);
        Task<User> GetUserByIdAsync(int id);
    }
}
