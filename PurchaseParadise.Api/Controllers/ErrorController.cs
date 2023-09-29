using Microsoft.AspNetCore.Mvc;
using PurchaseParadise.Api.Errors;

namespace PurchaseParadise.Api.Controllers;

[Route("errors/{code}")]
[ApiController]
[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorController : BaseApiController
{
    public IActionResult Error(int code)
    {
        return new ObjectResult(new ApiResponse(code));
    }
}
