namespace Space.Backend.Services.AutorizationService
{
    public interface IPasswordWalidator
    {
       Task<bool> IsValidatePassword(string Password);
    }
}
