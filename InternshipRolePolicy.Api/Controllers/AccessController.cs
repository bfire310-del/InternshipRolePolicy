using InternshipRolePolicy.Api.Requests;
using InternshipRolePolicy.Application.Query.LoginQuery;
using Microsoft.AspNetCore.Mvc;

namespace InternshipRolePolicy.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccessController : BaseController
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var result = await Mediator.Send(new LoginQuery(request.Email, request.Password));

        if (result.IsFailed)
            return ProblemResponse(result.Error);

        return Ok(new
        {
            token = result.Value.Item1,
            roleCode = result.Value.Item2,
            firstName = result.Value.Item3,
            lastName = result.Value.Item4
        });
    }
}
