using Grpc.Core;
using Space.Backend.Proto;
using User = Space.Backend.Models.Enteties.User;

namespace Space.Backend.Services.AutorizationService
{
    public class AutorizationService : Autorization.AutorizationBase
    {
        private readonly ILogger<AutorizationService> _logger;
        private readonly IAutorizationService _service;
        public AutorizationService(IAutorizationService service,ILogger<AutorizationService> logger) 
        {
            _logger = logger;
            _service = service;
        }

        public override async Task<RegistrResponse> Rgistration(RegistrRequest request, ServerCallContext context)
        {
            if (request.Password != request.ConfirmPassword)
            {
                return new RegistrResponse
                {
                    Success = false,
                    Message = "Passwords do not match",
                    User = null
                };
            }

            var registerModel = new RegistrRequest
            {
                Username = request.Username,
                Email = request.Email,
                Password = request.Password,
                ConfirmPassword = request.ConfirmPassword
            };

            var user = await _service.RegisterAsync(registerModel);
            return new RegistrResponse
            {
                Success = true,
                Message = "Registration successful",
                User = new UserMessage
                {
                    Id = user.Id,
                    Username = user.Name,
                    Email = user.Email,
                }
            };
        }
    }
}
