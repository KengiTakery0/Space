
namespace Space.Backend.Services.AutorizationService
{
    public class AutorizationService : IAutorizationService, IPasswordWalidator
    {
        public async Task AutorizeAsync(string? Phone, string? Email, string Password, CancellationToken token = default)
        {
            
           await IsValidatePassword(Password);
        }

        public async Task<bool> IsValidatePassword(string Password)
        {
            bool isValid = false;
            if (Password == null) return false;
            if(Password.Length == 0) return false;
            else return true;     
        }
    }
}
