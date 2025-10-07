namespace Ecom.Api.Models;

public class Payment
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }

    public int OrderId { get; set; }
    public Order? Order { get; set; }

    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
    public string PaymentMethod { get; set; } = "Card"; // Card, PayPal, COD
    public string Status { get; set; } = "Pending";     // Pending, Completed, Failed
}
