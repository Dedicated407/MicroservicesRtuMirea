using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DeZon.Orders.Controllers;

[ApiController]
[Route("api/roles")]
public class RoleController : ControllerBase
{
    [HttpGet]
    // [Authorize(Policy = nameof(Roles.Critic))]
    public IActionResult GetRoles()
    {
        return Ok();
    }
}