using ExceptionMiddleware.Exception;
using ExceptionMiddleware.Exception.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionMiddleware.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExceptionsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int number)
    {
        if (number == 5)
        {
            throw new UserFriendlyException(ApiException.ExceptionMessages.AuthorizationsDenied);
        }
        return Ok();
    }
    
}