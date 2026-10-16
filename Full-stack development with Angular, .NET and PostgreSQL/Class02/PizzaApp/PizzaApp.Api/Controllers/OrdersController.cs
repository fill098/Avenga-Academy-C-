using Microsoft.AspNetCore.Mvc;
using PizzaApp.Dtos.Order;
using PizzaApp.Services.Abstractions;

namespace PizzaApp.Api.Controllers;

public class OrdersController : ApiControllerBase
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]

    public async Task<ActionResult<List<OrderDto>>> GetAll(CancellationToken cancellationToken)
    {
        var pizzas = await _orderService.GetAllAsync(cancellationToken);
        return Ok(pizzas);
    }

    [HttpGet("{id:int}")]

    public async Task<ActionResult<OrderDto>> GetById(int id, CancellationToken cancellationToken)
    {
        var pizza = await _orderService.GetByIdAsync(id, cancellationToken);
        return Ok(pizza);
    }

    [HttpPost]

    public async Task<ActionResult<OrderDto>> Create(AddOrderDto request, CancellationToken cancellationToken)
    {
        var newOrder = await _orderService.CreateAsync(request, cancellationToken);
        return CreatedAtAction(nameof(GetById), new { id = newOrder.Id }, newOrder);
    }

    [HttpPatch("id:int")]

    public async Task<ActionResult<OrderDto>> ChangeStatus(int id, ChangeOrderStatusDto request, CancellationToken cancellationToken)
    {
        var order = await _orderService.ChangeStatusAsync(id, request, cancellationToken);
        return Ok(order);
    }


}
