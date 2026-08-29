namespace Domain.Entites
{
    public class Order:BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalAmount { get; set; }
        public bool Stauts { get; set; } 
        public ICollection<OrderItem> OrderItems { get; set; }
    }

}
