using Microsoft.AspNetCore.Mvc;

namespace DeZon.Users.Controllers;

[ApiController]
[Route("api/roles")]
public class RoleController : ControllerBase
{
    [HttpGet]
    public IActionResult GetRoles()
    {
        return Ok(Enum.GetValues(typeof(Roles)).Cast<Roles>().ToList());
    }
}

public enum Roles
{
    User,
    Moderator,
    Admin
}