namespace SMP.Core.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Supp_Name { get; set; }
        public string? Supp_Phone { get; set; }
        public string? Supp_Email { get; set;}
        public virtual ICollection<Purchase>? Purchases { get; set; }
    }
}
