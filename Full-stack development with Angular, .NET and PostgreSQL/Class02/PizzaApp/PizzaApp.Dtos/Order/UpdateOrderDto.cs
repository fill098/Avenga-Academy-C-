using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Dtos.Order;

public class UpdateOrderDto
{
    /// <summary>
    /// Changes the delivery details of an order that is still Pending.
    /// </summary>

    [Required]
    [StringLength(200)]
    public string AddressTo { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }
}
