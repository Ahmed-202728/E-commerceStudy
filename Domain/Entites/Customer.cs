namespace Domain.Entites
{
    public class Customer:BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Guid CompanyId { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

}
