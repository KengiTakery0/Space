namespace Space.Backend.Services.AutorizationService
{
    public interface IAutorizationService
    {
        Task AutorizeAsync(string? Phone, string? Email, string Password, CancellationToken token = default);
    }
}
