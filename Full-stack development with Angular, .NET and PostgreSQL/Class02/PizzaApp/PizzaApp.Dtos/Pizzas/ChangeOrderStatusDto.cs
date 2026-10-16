using System.ComponentModel.DataAnnotations;
using PizzaApp.Domain.Enums;

namespace PizzaApp.Dtos.Pizzas;

public class ChangeOrderStatusDto
{
    /// <summary>"Pending", "Preparing", "Delivered" or "Cancelled".</summary>
    [Required]
    public OrderStatus? Status { get; set; }
}

