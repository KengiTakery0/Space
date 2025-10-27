using Microsoft.AspNetCore.Identity.Data;
using Space.Service.Autorization.Data.Repositories.Implimentations;
using Space.Service.Autorization.Models.DTOs.Response;
using Space.Service.Autorization.Models.Entity;

namespace Space.Service.Autorization.Services.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponse> RegisterAsync(RegisterRequest request);
        Task<LoginResponse> LoginAsync(LoginRequest request);
        Task<LoginResponse> RefreshTokenAsync(string refreshToken);
        Task<bool> RevokeTokenAsync(string refreshToken);
        Task<bool> LogoutAsync(Guid userId, string refreshToken);
    }
}
