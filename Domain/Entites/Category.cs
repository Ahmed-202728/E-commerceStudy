namespace Domain.Entites
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsActive { get; set; } = true;
        public Company Company { get; set; }
        public ICollection<Product> Products { get; set; }
    }

}
