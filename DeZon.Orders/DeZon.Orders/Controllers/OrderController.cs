using DeZon.Orders.Entities;
using DeZon.Orders.Infrastructure.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DeZon.Orders.Controllers;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{
    private readonly IRepository _repository;
    private readonly ILogger<OrderController> _logger;

    public OrderController(IRepository repository, ILogger<OrderController> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    [HttpGet("graylog")]
    public IActionResult TestGraylog()
    {
        _logger.LogInformation("Request from TestGraylog (api/orders/graylog).");
        return Ok();
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromQuery] string name, CancellationToken cancellationToken)
    {
        var order = new Order(name);
        
        await _repository.AddAsync(order, cancellationToken);
        await _repository.SaveChangesAsync(cancellationToken);
        
        return Ok();
    }
    
    [HttpGet]
    public async Task<IActionResult> GetOrders(CancellationToken cancellationToken)
    {
        var query = _repository.Orders.AsQueryable();
        var entities = await query.ToArrayAsync(cancellationToken);
        
        return Ok(entities);
    }
}