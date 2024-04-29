using SMP.Core.Interfaces;
using SMP.Core.Models;
using SMP.EF.Data;
using SMP.EF.Repositories;

namespace SMP.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IDataHelper<Category> _catHelper { get; private set; }

        public IDataHelper<Customer> _cusHelper { get; private set; }

        public IDataHelper<Purchase> _purHelper { get; private set; }

        public IDataHelper<SellOperation> _sellHelper { get; private set; }

        public IDataHelper<Supplier> _supHelper { get; private set; }

        public IDataHelper<SystemRecords> _systemHelper { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            
            _catHelper = new DataHelper<Category>(_context);
            _cusHelper = new DataHelper<Customer>(_context);
            _purHelper = new DataHelper<Purchase>(_context);
            _sellHelper = new DataHelper<SellOperation>(_context);
            _supHelper = new DataHelper<Supplier>(_context);
            _systemHelper = new DataHelper<SystemRecords>(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
