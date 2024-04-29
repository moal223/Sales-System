namespace SMP.Core.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CAT_Name { get; set; }
        public virtual ICollection<Purchase>? Purchases { get; set; }
    }
}
