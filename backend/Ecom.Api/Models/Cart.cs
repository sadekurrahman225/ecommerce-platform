namespace Ecom.Api.Models;

public class Cart
{
    public int Id { get; set; }
    public int UserId { get; set; }

    public DateTime CreatAt { get; set; } = DateTime.UtcNow;

    public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}