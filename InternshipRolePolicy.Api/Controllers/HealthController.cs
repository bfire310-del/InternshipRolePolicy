using Microsoft.AspNetCore.Mvc;

namespace InternshipRolePolicy.Api.Controllers;

public class HealthController : Controller
{
    public async Task<IActionResult> Health()
    {
        return Ok();
    }
}
