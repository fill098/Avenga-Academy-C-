using PizzaApp.Dtos.Order;
using PizzaApp.Services.Abstractions;

namespace PizzaApp.Services.Implementations;

public class OrderService : IOrderService
{
    public Task<OrderDto> ChangeStatusAsync(int id, ChangeOrderStatusDto request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task<OrderDto> CreateAsync(AddOrderDto request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task DeleteAsync(int id, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task<List<OrderDto>> GetAllAsync(CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task<OrderDto> GetByIdAsync(int id, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task<OrderDto> UpdateAsync(int id, UpdateOrderDto request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
}
