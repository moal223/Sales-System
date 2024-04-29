using System.ComponentModel.DataAnnotations;

namespace SMP.Core.Models
{
    public class SellOperation
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Sell_Name { get; set; }
        [MaxLength(50)]
        public string? Sell_Cus { get; set; }
        public float Quantity { get; set; }
        public float TPrice { get; set; }
        public DateTime Sell_Date { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
