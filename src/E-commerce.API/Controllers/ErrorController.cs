using E_commerce.Domain.Error;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce.API.Controllers
{
    [Route("errors/{code}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : BaseController
    {
        
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ErrorResponse(code));
        }
    }
}
