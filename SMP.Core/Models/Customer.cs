namespace SMP.Core.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Cus_Name { get; set; }
        public string? Cus_Phone { get; set; }
        public string? Cus_Email { get; set; }

        public virtual ICollection<SellOperation>? SellOperations { get; set; }
    }
}
