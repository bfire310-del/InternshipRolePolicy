using InternshipRolePolicy.Application.Query.GetAllUsers;
using Microsoft.AspNetCore.Mvc;

namespace InternshipRolePolicy.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : BaseController
{
    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var result = await Mediator.Send(new GetAllUsersQuery());

        if (result.IsFailed)
            return ProblemResponse(result.Error);

        return Ok(result.Value);
    }
}
