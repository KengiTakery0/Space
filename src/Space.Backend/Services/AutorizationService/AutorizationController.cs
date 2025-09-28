using Microsoft.AspNetCore.Mvc;

namespace Space.Backend.Services.AutorizationService
{
    [ApiController]
    [Route("Autorization")]
    public class AutorizationController(IAutorizationService autorizationService) : ControllerBase 
    {
        [HttpPost]
        public async Task AutorizeAsync(string pas)
        {
            await autorizationService.AutorizeAsync(null,null,pas);
            
        }
    }
}
