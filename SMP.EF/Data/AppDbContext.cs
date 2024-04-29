using Microsoft.EntityFrameworkCore;
using SMP.Core.Models;

namespace SMP.EF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string sqlcon = "Data Source=DESKTOP-NQ3D5TK;Initial Catalog=DB_SMP;Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(sqlcon);
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<SystemRecords> SystemRecords { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<SellOperation> SellOperations { get; set; }
    }
}
