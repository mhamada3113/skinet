using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //means that the route will be api/BaseApi --> api/Products because Products controller is inhertence from BaseApi
    public class BaseApiController : ControllerBase
    {
        
    }
}