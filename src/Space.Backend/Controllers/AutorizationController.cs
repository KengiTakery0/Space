using Microsoft.AspNetCore.Mvc;
using Space.Backend.Controllers;
using Space.Backend.Services.AutorizationService;

namespace Space.Backend.Controllers
{
    [ApiController]
    [Route("Autorization")]
    public class AutorizationController(IAutorizationService autorizationService) : ControllerBase 
    {
        
    }
}
