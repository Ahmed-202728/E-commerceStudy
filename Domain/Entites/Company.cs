namespace Domain.Entites
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }= true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Category> Categories { get; set; }
    } 

}
