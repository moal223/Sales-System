using System.ComponentModel.DataAnnotations;

namespace SMP.Core.Models
{
    public class Purchase
    {
        public int Id { set; get; }
        [MaxLength(50)]
        public string Pur_Name { set; get; }
        [MaxLength(50)]
        public string? Pur_Type { set; get; }
        [MaxLength(50)]
        public string? Pur_Cat { set; get; }
        [MaxLength(50)]
        public string? Pur_Supp { set; get; }
        public string? Pur_Details { set; get; }
        public double? Pur_Buy { set; get; }
        public double? Pur_Sell { set; get; }
        public double? Pur_Qt { set; get; }
        public double? Pur_TSell { set; get; }
        public double? Pur_TBuy { set; get; }
        public double? Pur_TRev { set; get; }
        public bool IsDelete { set; get; }

        //Navigation
        public virtual Category? Categories { set; get; }
        public virtual Supplier? Suppliers { set; get; }
    }
}
