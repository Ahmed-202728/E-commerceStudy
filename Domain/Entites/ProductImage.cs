namespace Domain.Entites
{
    public class ProductImage:BaseEntity
    {
        public string ImageUrl { get; set; }
        public Guid ProductId { get; set; } 
        public Product Product { get; set; }
        public bool IsMain { get; set; }
    }

}
