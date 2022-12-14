using DeZon.Users.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace DeZon.Users.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IRepository _repository;

    public UserController(IRepository repository)
    {
        _repository = repository;
    }
    
    [HttpPost]
    public IActionResult Add([FromQuery] string name)
    {
        var result = _repository.Add(name);

        return Ok(result);
    }
    
    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(_repository.GetAll());
    }
}