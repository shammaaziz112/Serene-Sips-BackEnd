using System.ComponentModel.DataAnnotations;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entity;
public class Product
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    public Guid CategoryId { get; set; }
    [Required]
    public string Name { get; set; }

    public double Price { get; set; }

    public string Image { get; set; }
  
    public int Quantity { get; set; }
    public string Description { get; set; }
    public IEnumerable<OrderItem> OrderItems { get; set; }
}
