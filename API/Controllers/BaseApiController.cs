using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //Controller base that other controlllers in Inheerit from 
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        
    }
}