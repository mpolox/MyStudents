using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using System.Net;

namespace MyStudents.Controllers
{

    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : Controller
    {
        [Route("Error")]
        [AllowAnonymous]
        public IActionResult Error()
        {

            var myResponse = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            var errorPath = myResponse.Path;
            var errorMessage = myResponse.Error.Message;
            var errorStackTrace = myResponse.Error.StackTrace;
            errorMessage = "PATH:" + errorPath + " MESSAGE:" + errorMessage + " STACKTRACE:" + errorStackTrace;

            var myStatus = myResponse.Error.GetType().Name switch
            {
                "ArgumentException" => HttpStatusCode.BadRequest,
                "UndefinedException" => HttpStatusCode.NotFound,
                _ => HttpStatusCode.ServiceUnavailable
            };
            //myResponse.StatusCode = statusCode;
            return Problem(detail: errorMessage, statusCode: (int)myStatus);
        }
    }
}
